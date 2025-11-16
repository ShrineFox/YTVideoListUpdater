using Newtonsoft.Json;
using System.Windows.Forms;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;

namespace YTVideoListUpdater
{
    public partial class YTVidListUpdater : Form
    {
        public static Settings settings;
        BindingSource bs = new BindingSource();

        public YTVidListUpdater()
        {
            string jsonPath = "./settings.json";
            InitializeComponent();
            LoadJson(jsonPath);
            bs.DataSource = settings.Channels;
            comboBox_Channel.DataSource = bs;
            comboBox_Channel.ValueMember = "Name";
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

            btn_UpdateVideoList.Enabled = true;
        }

        private void ProcessOutputText(string txtPath, string outPath)
        {
            using (WaitForFile(txtPath)) { };
            if (!File.Exists(txtPath))
                txtPath = "./--";

            using (WaitForFile(txtPath)) { };
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

        }

        public class YTChannel
        {
            public string Name { get; set; } = "";
            public string ID { get; set; } = "";
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
    }
}
