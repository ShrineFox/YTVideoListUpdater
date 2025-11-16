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
            tlp_Main = new TableLayoutPanel();
            groupBox_Channel = new GroupBox();
            comboBox_Channel = new ComboBox();
            btn_UpdateVideoList = new Button();
            txt_Log = new TextBox();
            tlp_Main.SuspendLayout();
            groupBox_Channel.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_Main
            // 
            tlp_Main.ColumnCount = 2;
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Main.Controls.Add(groupBox_Channel, 0, 0);
            tlp_Main.Controls.Add(btn_UpdateVideoList, 1, 0);
            tlp_Main.Controls.Add(txt_Log, 0, 1);
            tlp_Main.Dock = DockStyle.Fill;
            tlp_Main.Location = new Point(0, 0);
            tlp_Main.Name = "tlp_Main";
            tlp_Main.RowCount = 2;
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlp_Main.Size = new Size(442, 353);
            tlp_Main.TabIndex = 0;
            // 
            // groupBox_Channel
            // 
            groupBox_Channel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Channel.Controls.Add(comboBox_Channel);
            groupBox_Channel.Location = new Point(3, 3);
            groupBox_Channel.Name = "groupBox_Channel";
            groupBox_Channel.Size = new Size(347, 64);
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
            comboBox_Channel.Size = new Size(341, 28);
            comboBox_Channel.TabIndex = 0;
            // 
            // btn_UpdateVideoList
            // 
            btn_UpdateVideoList.Dock = DockStyle.Fill;
            btn_UpdateVideoList.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_UpdateVideoList.Location = new Point(356, 3);
            btn_UpdateVideoList.Name = "btn_UpdateVideoList";
            btn_UpdateVideoList.Size = new Size(83, 64);
            btn_UpdateVideoList.TabIndex = 1;
            btn_UpdateVideoList.Text = "Update Video List";
            btn_UpdateVideoList.UseVisualStyleBackColor = true;
            btn_UpdateVideoList.Click += UpdateVideoList_Click;
            // 
            // txt_Log
            // 
            txt_Log.Dock = DockStyle.Fill;
            txt_Log.Location = new Point(3, 73);
            txt_Log.Multiline = true;
            txt_Log.Name = "txt_Log";
            txt_Log.ReadOnly = true;
            txt_Log.Size = new Size(347, 277);
            txt_Log.TabIndex = 2;
            // 
            // YTVidListUpdater
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 353);
            Controls.Add(tlp_Main);
            MinimumSize = new Size(460, 400);
            Name = "YTVidListUpdater";
            Text = "YTVideoListUpdater";
            tlp_Main.ResumeLayout(false);
            tlp_Main.PerformLayout();
            groupBox_Channel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_Main;
        private GroupBox groupBox_Channel;
        private ComboBox comboBox_Channel;
        private Button btn_UpdateVideoList;
        private TextBox txt_Log;
    }
}
