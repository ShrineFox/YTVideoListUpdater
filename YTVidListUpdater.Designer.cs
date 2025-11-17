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
            tlp_ListUpdater = new TableLayoutPanel();
            groupBox_Channel = new GroupBox();
            comboBox_Channel = new ComboBox();
            btn_UpdateVideoList = new Button();
            txt_Log = new TextBox();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel_Downloader = new TableLayoutPanel();
            groupBox_Video = new GroupBox();
            comboBox_Video = new ComboBox();
            txt_DownloadLog = new TextBox();
            groupBox1 = new GroupBox();
            comboBox_ChannelDownload = new ComboBox();
            btn_Download = new Button();
            groupBox_Cmd = new GroupBox();
            txt_CmdArgs = new TextBox();
            tabPage2 = new TabPage();
            tlp_ListUpdater.SuspendLayout();
            groupBox_Channel.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel_Downloader.SuspendLayout();
            groupBox_Video.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox_Cmd.SuspendLayout();
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
            tlp_ListUpdater.Size = new Size(428, 314);
            tlp_ListUpdater.TabIndex = 0;
            // 
            // groupBox_Channel
            // 
            groupBox_Channel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Channel.Controls.Add(comboBox_Channel);
            groupBox_Channel.Location = new Point(3, 3);
            groupBox_Channel.Name = "groupBox_Channel";
            groupBox_Channel.Size = new Size(336, 56);
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
            comboBox_Channel.Size = new Size(330, 28);
            comboBox_Channel.TabIndex = 0;
            // 
            // btn_UpdateVideoList
            // 
            btn_UpdateVideoList.Dock = DockStyle.Fill;
            btn_UpdateVideoList.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn_UpdateVideoList.Location = new Point(345, 3);
            btn_UpdateVideoList.Name = "btn_UpdateVideoList";
            btn_UpdateVideoList.Size = new Size(80, 56);
            btn_UpdateVideoList.TabIndex = 1;
            btn_UpdateVideoList.Text = "Update Video List";
            btn_UpdateVideoList.UseVisualStyleBackColor = true;
            btn_UpdateVideoList.Click += UpdateVideoList_Click;
            // 
            // txt_Log
            // 
            tlp_ListUpdater.SetColumnSpan(txt_Log, 2);
            txt_Log.Dock = DockStyle.Fill;
            txt_Log.Location = new Point(3, 65);
            txt_Log.Multiline = true;
            txt_Log.Name = "txt_Log";
            txt_Log.ReadOnly = true;
            txt_Log.ScrollBars = ScrollBars.Vertical;
            txt_Log.Size = new Size(422, 246);
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
            tabControl.Size = new Size(442, 353);
            tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel_Downloader);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(434, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video Downloader";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Downloader
            // 
            tableLayoutPanel_Downloader.ColumnCount = 2;
            tableLayoutPanel_Downloader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel_Downloader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Downloader.Controls.Add(groupBox_Video, 0, 1);
            tableLayoutPanel_Downloader.Controls.Add(txt_DownloadLog, 0, 3);
            tableLayoutPanel_Downloader.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel_Downloader.Controls.Add(btn_Download, 1, 1);
            tableLayoutPanel_Downloader.Controls.Add(groupBox_Cmd, 0, 2);
            tableLayoutPanel_Downloader.Dock = DockStyle.Fill;
            tableLayoutPanel_Downloader.Location = new Point(3, 3);
            tableLayoutPanel_Downloader.Name = "tableLayoutPanel_Downloader";
            tableLayoutPanel_Downloader.RowCount = 4;
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel_Downloader.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Downloader.Size = new Size(428, 314);
            tableLayoutPanel_Downloader.TabIndex = 1;
            // 
            // groupBox_Video
            // 
            groupBox_Video.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Video.Controls.Add(comboBox_Video);
            groupBox_Video.Location = new Point(3, 65);
            groupBox_Video.Name = "groupBox_Video";
            groupBox_Video.Size = new Size(336, 56);
            groupBox_Video.TabIndex = 4;
            groupBox_Video.TabStop = false;
            groupBox_Video.Text = "Video";
            // 
            // comboBox_Video
            // 
            comboBox_Video.Dock = DockStyle.Fill;
            comboBox_Video.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Video.FormattingEnabled = true;
            comboBox_Video.Location = new Point(3, 23);
            comboBox_Video.Name = "comboBox_Video";
            comboBox_Video.Size = new Size(330, 28);
            comboBox_Video.TabIndex = 0;
            // 
            // txt_DownloadLog
            // 
            tableLayoutPanel_Downloader.SetColumnSpan(txt_DownloadLog, 2);
            txt_DownloadLog.Dock = DockStyle.Fill;
            txt_DownloadLog.Location = new Point(3, 252);
            txt_DownloadLog.Multiline = true;
            txt_DownloadLog.Name = "txt_DownloadLog";
            txt_DownloadLog.ReadOnly = true;
            txt_DownloadLog.ScrollBars = ScrollBars.Vertical;
            txt_DownloadLog.Size = new Size(422, 59);
            txt_DownloadLog.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(comboBox_ChannelDownload);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 56);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Channel";
            // 
            // comboBox_ChannelDownload
            // 
            comboBox_ChannelDownload.Dock = DockStyle.Fill;
            comboBox_ChannelDownload.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ChannelDownload.FormattingEnabled = true;
            comboBox_ChannelDownload.Location = new Point(3, 23);
            comboBox_ChannelDownload.Name = "comboBox_ChannelDownload";
            comboBox_ChannelDownload.Size = new Size(330, 28);
            comboBox_ChannelDownload.TabIndex = 0;
            comboBox_ChannelDownload.SelectedIndexChanged += ChannelDownload_Changed;
            // 
            // btn_Download
            // 
            btn_Download.Dock = DockStyle.Fill;
            btn_Download.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            btn_Download.Location = new Point(345, 65);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(80, 56);
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
            groupBox_Cmd.Location = new Point(3, 127);
            groupBox_Cmd.Name = "groupBox_Cmd";
            groupBox_Cmd.Size = new Size(422, 119);
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
            txt_CmdArgs.Size = new Size(416, 93);
            txt_CmdArgs.TabIndex = 0;
            txt_CmdArgs.TextChanged += Cmd_Changed;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tlp_ListUpdater);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(434, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "List Updater";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // YTVidListUpdater
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 353);
            Controls.Add(tabControl);
            MinimumSize = new Size(460, 400);
            Name = "YTVidListUpdater";
            Text = "YTVideoListUpdater";
            tlp_ListUpdater.ResumeLayout(false);
            tlp_ListUpdater.PerformLayout();
            groupBox_Channel.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel_Downloader.ResumeLayout(false);
            tableLayoutPanel_Downloader.PerformLayout();
            groupBox_Video.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox_Cmd.ResumeLayout(false);
            groupBox_Cmd.PerformLayout();
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
        private GroupBox groupBox1;
        private ComboBox comboBox_ChannelDownload;
        private Button btn_Download;
        private GroupBox groupBox_Video;
        private ComboBox comboBox_Video;
        private TextBox txt_DownloadLog;
        private GroupBox groupBox_Cmd;
        private TextBox txt_CmdArgs;
    }
}
