namespace YTVideoListUpdater
{
    partial class YTVidListUpdater
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YTVidListUpdater));
            tlp_ListUpdater = new TableLayoutPanel();
            groupBox_Channel = new GroupBox();
            comboBox_Channel = new ComboBox();
            btn_UpdateVideoList = new Button();
            txt_Log = new TextBox();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel_Downloader = new TableLayoutPanel();
            button1 = new Button();
            txt_DownloadLog = new TextBox();
            groupBox_DownloadChannel = new GroupBox();
            comboBox_ChannelDownload = new ComboBox();
            btn_Download = new Button();
            groupBox_Cmd = new GroupBox();
            txt_CmdArgs = new TextBox();
            groupBox_Video = new GroupBox();
            comboBox_Video = new ComboBox();
            groupBox_VideoSearch = new GroupBox();
            txt_VideoSearch = new TextBox();
            groupBox_Range = new GroupBox();
            tlp_TimeRange = new TableLayoutPanel();
            txt_to = new TextBox();
            txt_from = new TextBox();
            lbl_from = new Label();
            lbl_to = new Label();
            chk_UseTimeStampRange = new CheckBox();
            chk_LaunchCmd = new CheckBox();
            tabPage2 = new TabPage();
            tlp_ListUpdater.SuspendLayout();
            groupBox_Channel.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel_Downloader.SuspendLayout();
            groupBox_DownloadChannel.SuspendLayout();
            groupBox_Cmd.SuspendLayout();
            groupBox_Video.SuspendLayout();
            groupBox_VideoSearch.SuspendLayout();
            groupBox_Range.SuspendLayout();
            tlp_TimeRange.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_ListUpdater
            // 
            tlp_ListUpdater.ColumnCount = 2;
            tlp_ListUpdater.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_ListUpdater.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_ListUpdater.Controls.Add(groupBox_Channel, 0, 0);
            tlp_ListUpdater.Controls.Add(btn_UpdateVideoList, 1, 0);
            tlp_ListUpdater.Controls.Add(txt_Log, 0, 1);
            tlp_ListUpdater.Dock = DockStyle.Fill;
            tlp_ListUpdater.Location = new Point(3, 3);
            tlp_ListUpdater.Name = "tlp_ListUpdater";
            tlp_ListUpdater.RowCount = 2;
            tlp_ListUpdater.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_ListUpdater.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlp_ListUpdater.Size = new Size(537, 452);
            tlp_ListUpdater.TabIndex = 0;
            // 
            // groupBox_Channel
            // 
            groupBox_Channel.Controls.Add(comboBox_Channel);
            groupBox_Channel.Dock = DockStyle.Fill;
            groupBox_Channel.Location = new Point(3, 3);
            groupBox_Channel.Name = "groupBox_Channel";
            groupBox_Channel.Size = new Size(423, 84);
            groupBox_Channel.TabIndex = 0;
            groupBox_Channel.TabStop = false;
            groupBox_Channel.Text = "Channel";
            // 
            // comboBox_Channel
            // 
            comboBox_Channel.Dock = DockStyle.Fill;
            comboBox_Channel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Channel.FormattingEnabled = true;
            comboBox_Channel.Location = new Point(3, 23);
            comboBox_Channel.Name = "comboBox_Channel";
            comboBox_Channel.Size = new Size(417, 28);
            comboBox_Channel.TabIndex = 0;
            // 
            // btn_UpdateVideoList
            // 
            btn_UpdateVideoList.Dock = DockStyle.Fill;
            btn_UpdateVideoList.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn_UpdateVideoList.Location = new Point(432, 3);
            btn_UpdateVideoList.Name = "btn_UpdateVideoList";
            btn_UpdateVideoList.Size = new Size(102, 84);
            btn_UpdateVideoList.TabIndex = 1;
            btn_UpdateVideoList.Text = "Update Video List";
            btn_UpdateVideoList.UseVisualStyleBackColor = true;
            btn_UpdateVideoList.Click += UpdateVideoList_Click;
            // 
            // txt_Log
            // 
            tlp_ListUpdater.SetColumnSpan(txt_Log, 2);
            txt_Log.Dock = DockStyle.Fill;
            txt_Log.Location = new Point(3, 93);
            txt_Log.Multiline = true;
            txt_Log.Name = "txt_Log";
            txt_Log.ReadOnly = true;
            txt_Log.ScrollBars = ScrollBars.Vertical;
            txt_Log.Size = new Size(531, 356);
            txt_Log.TabIndex = 2;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(551, 491);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel_Downloader);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(543, 458);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video Downloader";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Downloader
            // 
            tableLayoutPanel_Downloader.ColumnCount = 2;
            tableLayoutPanel_Downloader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel_Downloader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Downloader.Controls.Add(button1, 1, 0);
            tableLayoutPanel_Downloader.Controls.Add(txt_DownloadLog, 0, 5);
            tableLayoutPanel_Downloader.Controls.Add(groupBox_DownloadChannel, 0, 0);
            tableLayoutPanel_Downloader.Controls.Add(btn_Download, 1, 1);
            tableLayoutPanel_Downloader.Controls.Add(groupBox_Cmd, 0, 4);
            tableLayoutPanel_Downloader.Controls.Add(groupBox_Video, 0, 1);
            tableLayoutPanel_Downloader.Controls.Add(groupBox_VideoSearch, 0, 2);
            tableLayoutPanel_Downloader.Controls.Add(groupBox_Range, 0, 3);
            tableLayoutPanel_Downloader.Controls.Add(chk_UseTimeStampRange, 1, 3);
            tableLayoutPanel_Downloader.Controls.Add(chk_LaunchCmd, 1, 2);
            tableLayoutPanel_Downloader.Dock = DockStyle.Fill;
            tableLayoutPanel_Downloader.Location = new Point(3, 3);
            tableLayoutPanel_Downloader.Name = "tableLayoutPanel_Downloader";
            tableLayoutPanel_Downloader.RowCount = 6;
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Downloader.Size = new Size(537, 452);
            tableLayoutPanel_Downloader.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            button1.Location = new Point(432, 3);
            button1.Name = "button1";
            button1.Size = new Size(102, 61);
            button1.TabIndex = 10;
            button1.Text = "Download All Videos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DownloadAllVideos_Click;
            // 
            // txt_DownloadLog
            // 
            tableLayoutPanel_Downloader.SetColumnSpan(txt_DownloadLog, 2);
            txt_DownloadLog.Dock = DockStyle.Fill;
            txt_DownloadLog.Location = new Point(3, 361);
            txt_DownloadLog.Multiline = true;
            txt_DownloadLog.Name = "txt_DownloadLog";
            txt_DownloadLog.ReadOnly = true;
            txt_DownloadLog.ScrollBars = ScrollBars.Vertical;
            txt_DownloadLog.Size = new Size(531, 88);
            txt_DownloadLog.TabIndex = 3;
            // 
            // groupBox_DownloadChannel
            // 
            groupBox_DownloadChannel.Controls.Add(comboBox_ChannelDownload);
            groupBox_DownloadChannel.Dock = DockStyle.Fill;
            groupBox_DownloadChannel.Location = new Point(3, 3);
            groupBox_DownloadChannel.Name = "groupBox_DownloadChannel";
            groupBox_DownloadChannel.Size = new Size(423, 61);
            groupBox_DownloadChannel.TabIndex = 0;
            groupBox_DownloadChannel.TabStop = false;
            groupBox_DownloadChannel.Text = "Channel";
            // 
            // comboBox_ChannelDownload
            // 
            comboBox_ChannelDownload.Dock = DockStyle.Fill;
            comboBox_ChannelDownload.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ChannelDownload.FormattingEnabled = true;
            comboBox_ChannelDownload.Location = new Point(3, 23);
            comboBox_ChannelDownload.Name = "comboBox_ChannelDownload";
            comboBox_ChannelDownload.Size = new Size(417, 28);
            comboBox_ChannelDownload.TabIndex = 0;
            comboBox_ChannelDownload.SelectedIndexChanged += ChannelDownload_Changed;
            // 
            // btn_Download
            // 
            btn_Download.Dock = DockStyle.Fill;
            btn_Download.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn_Download.Location = new Point(432, 70);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(102, 61);
            btn_Download.TabIndex = 1;
            btn_Download.Text = "Download Video";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += Download_Click;
            // 
            // groupBox_Cmd
            // 
            tableLayoutPanel_Downloader.SetColumnSpan(groupBox_Cmd, 2);
            groupBox_Cmd.Controls.Add(txt_CmdArgs);
            groupBox_Cmd.Dock = DockStyle.Fill;
            groupBox_Cmd.Location = new Point(3, 271);
            groupBox_Cmd.Name = "groupBox_Cmd";
            groupBox_Cmd.Size = new Size(531, 84);
            groupBox_Cmd.TabIndex = 5;
            groupBox_Cmd.TabStop = false;
            groupBox_Cmd.Text = "Commandline Arguments";
            // 
            // txt_CmdArgs
            // 
            txt_CmdArgs.Dock = DockStyle.Fill;
            txt_CmdArgs.Location = new Point(3, 23);
            txt_CmdArgs.Multiline = true;
            txt_CmdArgs.Name = "txt_CmdArgs";
            txt_CmdArgs.ScrollBars = ScrollBars.Vertical;
            txt_CmdArgs.Size = new Size(525, 58);
            txt_CmdArgs.TabIndex = 0;
            txt_CmdArgs.TextChanged += Cmd_Changed;
            // 
            // groupBox_Video
            // 
            groupBox_Video.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Video.Controls.Add(comboBox_Video);
            groupBox_Video.Location = new Point(3, 75);
            groupBox_Video.Name = "groupBox_Video";
            groupBox_Video.Size = new Size(423, 51);
            groupBox_Video.TabIndex = 5;
            groupBox_Video.TabStop = false;
            groupBox_Video.Text = "Selected Video";
            // 
            // comboBox_Video
            // 
            comboBox_Video.Dock = DockStyle.Fill;
            comboBox_Video.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Video.FormattingEnabled = true;
            comboBox_Video.Location = new Point(3, 23);
            comboBox_Video.Name = "comboBox_Video";
            comboBox_Video.Size = new Size(417, 28);
            comboBox_Video.TabIndex = 0;
            // 
            // groupBox_VideoSearch
            // 
            groupBox_VideoSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox_VideoSearch.Controls.Add(txt_VideoSearch);
            groupBox_VideoSearch.Location = new Point(3, 141);
            groupBox_VideoSearch.Name = "groupBox_VideoSearch";
            groupBox_VideoSearch.Size = new Size(423, 52);
            groupBox_VideoSearch.TabIndex = 6;
            groupBox_VideoSearch.TabStop = false;
            groupBox_VideoSearch.Text = "Video Search";
            // 
            // txt_VideoSearch
            // 
            txt_VideoSearch.Dock = DockStyle.Fill;
            txt_VideoSearch.Location = new Point(3, 23);
            txt_VideoSearch.Name = "txt_VideoSearch";
            txt_VideoSearch.ScrollBars = ScrollBars.Vertical;
            txt_VideoSearch.Size = new Size(417, 27);
            txt_VideoSearch.TabIndex = 1;
            txt_VideoSearch.KeyDown += Search_KeyDown;
            // 
            // groupBox_Range
            // 
            groupBox_Range.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Range.Controls.Add(tlp_TimeRange);
            groupBox_Range.Enabled = false;
            groupBox_Range.Location = new Point(3, 208);
            groupBox_Range.Name = "groupBox_Range";
            groupBox_Range.Size = new Size(423, 52);
            groupBox_Range.TabIndex = 7;
            groupBox_Range.TabStop = false;
            groupBox_Range.Text = "Timestamp Range";
            // 
            // tlp_TimeRange
            // 
            tlp_TimeRange.ColumnCount = 4;
            tlp_TimeRange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_TimeRange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_TimeRange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_TimeRange.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_TimeRange.Controls.Add(txt_to, 3, 0);
            tlp_TimeRange.Controls.Add(txt_from, 1, 0);
            tlp_TimeRange.Controls.Add(lbl_from, 0, 0);
            tlp_TimeRange.Controls.Add(lbl_to, 2, 0);
            tlp_TimeRange.Dock = DockStyle.Fill;
            tlp_TimeRange.Location = new Point(3, 23);
            tlp_TimeRange.Name = "tlp_TimeRange";
            tlp_TimeRange.RowCount = 1;
            tlp_TimeRange.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_TimeRange.Size = new Size(417, 26);
            tlp_TimeRange.TabIndex = 0;
            // 
            // txt_to
            // 
            txt_to.Dock = DockStyle.Fill;
            txt_to.Location = new Point(315, 3);
            txt_to.Name = "txt_to";
            txt_to.ScrollBars = ScrollBars.Vertical;
            txt_to.Size = new Size(99, 27);
            txt_to.TabIndex = 3;
            txt_to.Text = "00:02:00";
            // 
            // txt_from
            // 
            txt_from.Dock = DockStyle.Fill;
            txt_from.Location = new Point(107, 3);
            txt_from.Name = "txt_from";
            txt_from.ScrollBars = ScrollBars.Vertical;
            txt_from.Size = new Size(98, 27);
            txt_from.TabIndex = 2;
            txt_from.Text = "00:01:00";
            // 
            // lbl_from
            // 
            lbl_from.Anchor = AnchorStyles.Right;
            lbl_from.AutoSize = true;
            lbl_from.Location = new Point(57, 3);
            lbl_from.Name = "lbl_from";
            lbl_from.Size = new Size(44, 20);
            lbl_from.TabIndex = 0;
            lbl_from.Text = "from:";
            lbl_from.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_to
            // 
            lbl_to.Anchor = AnchorStyles.Right;
            lbl_to.AutoSize = true;
            lbl_to.Location = new Point(283, 3);
            lbl_to.Name = "lbl_to";
            lbl_to.Size = new Size(26, 20);
            lbl_to.TabIndex = 1;
            lbl_to.Text = "to:";
            lbl_to.TextAlign = ContentAlignment.MiddleRight;
            // 
            // chk_UseTimeStampRange
            // 
            chk_UseTimeStampRange.AutoSize = true;
            chk_UseTimeStampRange.Dock = DockStyle.Fill;
            chk_UseTimeStampRange.Location = new Point(432, 204);
            chk_UseTimeStampRange.Name = "chk_UseTimeStampRange";
            chk_UseTimeStampRange.Size = new Size(102, 61);
            chk_UseTimeStampRange.TabIndex = 8;
            chk_UseTimeStampRange.Text = "Use Range";
            chk_UseTimeStampRange.UseVisualStyleBackColor = true;
            chk_UseTimeStampRange.CheckedChanged += UseRange_CheckChanged;
            // 
            // chk_LaunchCmd
            // 
            chk_LaunchCmd.AutoSize = true;
            chk_LaunchCmd.Dock = DockStyle.Fill;
            chk_LaunchCmd.Font = new Font("Segoe UI", 8F);
            chk_LaunchCmd.Location = new Point(432, 137);
            chk_LaunchCmd.Name = "chk_LaunchCmd";
            chk_LaunchCmd.Size = new Size(102, 61);
            chk_LaunchCmd.TabIndex = 9;
            chk_LaunchCmd.Text = "Launch Cmd";
            chk_LaunchCmd.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tlp_ListUpdater);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(543, 458);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "List Updater";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // YTVidListUpdater
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 491);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(460, 400);
            Name = "YTVidListUpdater";
            Text = "YTVideoListUpdater v1.2.2";
            tlp_ListUpdater.ResumeLayout(false);
            tlp_ListUpdater.PerformLayout();
            groupBox_Channel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel_Downloader.ResumeLayout(false);
            tableLayoutPanel_Downloader.PerformLayout();
            groupBox_DownloadChannel.ResumeLayout(false);
            groupBox_Cmd.ResumeLayout(false);
            groupBox_Cmd.PerformLayout();
            groupBox_Video.ResumeLayout(false);
            groupBox_VideoSearch.ResumeLayout(false);
            groupBox_VideoSearch.PerformLayout();
            groupBox_Range.ResumeLayout(false);
            tlp_TimeRange.ResumeLayout(false);
            tlp_TimeRange.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_ListUpdater;
        private GroupBox groupBox_Channel;
        private ComboBox comboBox_Channel;
        private Button btn_UpdateVideoList;
        private TextBox txt_Log;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel_Downloader;
        private GroupBox groupBox_DownloadChannel;
        private ComboBox comboBox_ChannelDownload;
        private Button btn_Download;
        private TextBox txt_DownloadLog;
        private GroupBox groupBox_Cmd;
        private TextBox txt_CmdArgs;
        private GroupBox groupBox_VideoSearch;
        private TextBox txt_VideoSearch;
        private GroupBox groupBox_Video;
        private ComboBox comboBox_Video;
        private GroupBox groupBox_Range;
        private TableLayoutPanel tlp_TimeRange;
        private Label lbl_from;
        private Label lbl_to;
        private TextBox txt_to;
        private TextBox txt_from;
        private CheckBox chk_UseTimeStampRange;
        private CheckBox chk_LaunchCmd;
        private Button button1;
    }
}
