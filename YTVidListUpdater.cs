using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;
using static YTVideoListUpdater.YTVidListUpdater;

namespace YTVideoListUpdater
{
    public partial class YTVidListUpdater : Form
    {
        public static string jsonPath;
        public static Settings settings;
        public static List<YTVideo> videos;
        BindingSource bs = new BindingSource();
        BindingSource bs2 = new BindingSource();
        BindingSource bs_videos = new BindingSource();

        public YTVidListUpdater()
        {
            jsonPath = "./settings.json";
            InitializeComponent();
            LoadJson(jsonPath);
            bs.DataSource = settings.Channels;
            bs2.DataSource = settings.Channels;
            bs_videos.DataSource = videos;

            comboBox_Channel.DataSource = bs;
            comboBox_ChannelDownload.DataSource = bs2;
            comboBox_Video.DataSource = bs_videos;
            comboBox_Channel.DisplayMember = "Name";
            comboBox_ChannelDownload.DisplayMember = "Name";
            comboBox_Video.DisplayMember = "Title";

            txt_CmdArgs.Text = settings.CmdLineArgs;
        }



        private async void ProcessChannel(YTChannel channel)
        {
            txt_Log.Text = $"Processing channel \"{channel.Name}\", please wait...";
            btn_UpdateVideoList.Enabled = false;

            string tempPath = "./--print-to-file";

            // yt-dlp.exe --skip-download --ignore-errors --flat-playlist --print-to-file $"%(upload_date)s{SEP}%(webpage_url)s{SEP}%(title)s{SEP}" urls.txt https://www.youtube.com/channel/UCzORJV8l3FWY4cFO8ot-F2w/videos

            var ytdl = new YoutubeDL
            {
                YoutubeDLPath = settings.YTDlpExePath
            };

            var options = new OptionSet
            {
                SkipDownload = true,
                IgnoreErrors = true,
                FlatPlaylist = true,
                PlaylistReverse = true,
                PrintToFile = new MultiValue<string>($"%(webpage_url)s\t%(title)s\t"),
                Output = channel.Name + ".txt"
            };

            if (File.Exists(tempPath))
                File.Delete(tempPath);
            if (File.Exists("./--"))
                File.Delete("./--");

            var runResult = await ytdl.RunWithOptions($"https://www.youtube.com/channel/{channel.ID}/videos", options);

            if (runResult.ErrorOutput != null)
                foreach (string str in runResult.ErrorOutput)
                    txt_Log.Text += "\r\n" + str;

            ProcessOutputText(tempPath, "./" + channel.Name + ".tsv");

            txt_Log.Text += $"\r\n\r\nDone updating \"{Path.GetFullPath(channel.Name + ".tsv")}\".";
            SystemSounds.Exclamation.Play();

            btn_UpdateVideoList.Enabled = true;
        }

        private void ProcessOutputText(string txtPath, string outPath)
        {
            using (WaitForFile(txtPath)) { }
            ;
            if (!File.Exists(txtPath))
                txtPath = "./--";

            using (WaitForFile(txtPath)) { }
            ;
            if (!File.Exists(txtPath))
            {
                txt_Log.Text = "Could not find temp output file.";
                return;
            }

            File.Copy(txtPath, outPath, true);
            txt_Log.Text = $"Saved video list to: \"{Path.GetFullPath(outPath)}\"";
        }

        public class Settings
        {
            [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
            public List<YTChannel> Channels { get; set; } = new List<YTChannel>();

            public string YTDlpExePath { get; set; } = "./yt-dlp.exe";
            [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Replace)]
            public string CmdLineArgs { get; set; } = "";

        }

        public class YTChannel
        {
            public string Name { get; set; } = "";
            public string ID { get; set; } = "";
        }

        public class YTVideo
        {
            public string URL { get; set; } = "";
            public string Title { get; set; } = "";
        }

        public void SaveJson(string jsonPath)
        {
            //settings = new Settings() { Channels = new List<YTChannel>() { new YTChannel() { ID = "UCrB3t1zAQPwAeWtI8RZIOvQ", Name = "ShrineFox" } } };
            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(settings, Newtonsoft.Json.Formatting.Indented));
        }

        public void LoadJson(string jsonPath)
        {
            if (!File.Exists(jsonPath))
                return;

            string jsonText = File.ReadAllText(Path.GetFullPath(jsonPath));
            settings = JsonConvert.DeserializeObject<Settings>(jsonText);
        }

        private void UpdateVideoList_Click(object sender, EventArgs e)
        {
            var channel = (YTChannel)comboBox_Channel.SelectedItem;

            ProcessChannel(channel);
        }

        public static FileStream WaitForFile(string fullPath,
            FileMode mode = FileMode.Open,
            FileAccess access = FileAccess.ReadWrite,
            FileShare share = FileShare.None)
        {
            for (int numTries = 0; numTries < 10; numTries++)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(fullPath, mode, access, share);
                    return fs;
                }
                catch (IOException)
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                    Thread.Sleep(400);
                }
            }
            return null;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            DownloadSelectedVideo();
        }

        private async void DownloadSelectedVideo()
        {
            var video = (YTVideo)comboBox_Video.SelectedItem;

            if (video == null) return;

            string optionsText = txt_CmdArgs.Text;
            if (chk_UseTimeStampRange.Checked)
                optionsText += $"\r\n--download-sections \"*{txt_from.Text}-{txt_to.Text}\"";

            if (chk_LaunchCmd.Checked)
            {
                Thread thred = new Thread(() => DownloadViaCmd(video, settings, optionsText));
                thred.Start();
                return;
            }

            btn_Download.Enabled = false;
            txt_DownloadLog.Clear();

            var ytdl = new YoutubeDL
            {
                YoutubeDLPath = settings.YTDlpExePath
            };

            OptionSet options = OptionSet.FromString(optionsText.Split('\n'));

            var runResult = await ytdl.RunWithOptions(video.URL, options);

            if (runResult.ErrorOutput != null)
                foreach (string str in runResult.ErrorOutput)
                    txt_DownloadLog.Text += "\r\n" + str;

            txt_DownloadLog.Text += $"\r\n\r\nDone downloading \"{video.Title}\".";

            SystemSounds.Exclamation.Play();

            btn_Download.Enabled = true;
        }

        private void DownloadViaCmd(YTVideo video, Settings settings, string optionsText)
        {
            using (Process p = new Process())
            {
                p.StartInfo.WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(settings.YTDlpExePath));

                p.StartInfo.FileName = Path.GetFullPath(settings.YTDlpExePath);
                p.StartInfo.Arguments = optionsText.Replace("\r", "").Replace("\n", " ") + $" {video.URL}";
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.StartInfo.CreateNoWindow = false;
                p.Start();
                txt_DownloadLog.Text += $"\r\nLaunching command prompt:\r\n\"{p.StartInfo.FileName}\" {p.StartInfo.Arguments}";
                p.WaitForExit();
            }
        }

        private void ChannelDownload_Changed(object sender, EventArgs e)
        {
            var channel = (YTChannel)comboBox_ChannelDownload.SelectedItem;

            UpdateVideoDownloadList(channel);
        }

        private void UpdateVideoDownloadList(YTChannel? channel)
        {
            if (!File.Exists(channel.Name + ".tsv"))
            {
                txt_DownloadLog.Text = $"Could not find \"{Path.GetFullPath(channel.Name + ".tsv")}\", " +
                    $"try downloading a video list for the channel first.";
                return;
            }

            UpdateVideoListDataSource(channel);
        }

        private void UpdateVideoListDataSource(YTChannel channel)
        {
            if (videos != null)
                videos.Clear();
            else
                videos = new List<YTVideo>();

            foreach (var line in File.ReadAllLines(channel.Name + ".tsv"))
                videos.Add(new YTVideo() { URL = line.Split('\t')[0], Title = line.Split('\t')[1] });
            bs_videos.DataSource = null;
            bs_videos.DataSource = videos;
        }

        private void Cmd_Changed(object sender, EventArgs e)
        {
            settings.CmdLineArgs = txt_CmdArgs.Text;

            SaveJson(jsonPath);
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            string searchTxt = txt_VideoSearch.Text.ToLower();
            if (string.IsNullOrEmpty(searchTxt))
                return;
            if (e.KeyData == Keys.Enter)
            {
                // stop windows ding noise
                e.Handled = true;
                e.SuppressKeyPress = true;

                int i = comboBox_Video.SelectedIndex + 1;
                while (i < comboBox_Video.Items.Count)
                {
                    if (i == comboBox_Video.SelectedIndex)
                        return;

                    var vid = (YTVideo)comboBox_Video.Items[i];

                    if (vid.Title.ToLower().Contains(searchTxt.ToLower()) ||
                        vid.URL.ToLower().Contains(searchTxt.ToLower())
                        )
                    {
                        comboBox_Video.SelectedIndex = i;
                        return;
                    }

                    if (i == comboBox_Video.Items.Count - 1)
                        i = 0;
                    else
                        i++;
                }
            }
        }

        private void UseRange_CheckChanged(object sender, EventArgs e)
        {
            if (chk_UseTimeStampRange.Checked)
                groupBox_Range.Enabled = true;
            else
                groupBox_Range.Enabled = false;
        }

        private void DownloadAllVideos_Click(object sender, EventArgs e)
        {
            YTVideo selectedVideo = (YTVideo)comboBox_Video.SelectedItem;

            foreach(var vid in videos.SkipWhile(x => x != selectedVideo).Skip(1).Where(x => x.Title.Contains("Vinny")))
            {
                string optionsText = txt_CmdArgs.Text;
                if (chk_UseTimeStampRange.Checked)
                    optionsText += $"\r\n--download-sections \"*{txt_from.Text}-{txt_to.Text}\"";

                using (Process p = new Process())
                {
                    p.StartInfo.WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(settings.YTDlpExePath));

                    p.StartInfo.FileName = Path.GetFullPath(settings.YTDlpExePath);
                    p.StartInfo.Arguments = optionsText.Replace("\r", "").Replace("\n", " ") + $" {vid.URL}";
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    p.StartInfo.CreateNoWindow = false;
                    p.Start();
                    txt_DownloadLog.Text += $"\r\nLaunching command prompt:\r\n\"{p.StartInfo.FileName}\" {p.StartInfo.Arguments}";
                    p.WaitForExit();
                }
            }    
        }
    }
}
