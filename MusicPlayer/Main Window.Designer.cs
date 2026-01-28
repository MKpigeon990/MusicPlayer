namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.songList = new System.Windows.Forms.ListBox();
            this.chooseSongButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // songList
            // 
            this.songList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.songList.FormattingEnabled = true;
            this.songList.ItemHeight = 25;
            this.songList.Location = new System.Drawing.Point(822, 17);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(261, 479);
            this.songList.TabIndex = 0;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            // 
            // chooseSongButton
            // 
            this.chooseSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chooseSongButton.Location = new System.Drawing.Point(822, 502);
            this.chooseSongButton.Name = "chooseSongButton";
            this.chooseSongButton.Size = new System.Drawing.Size(261, 50);
            this.chooseSongButton.TabIndex = 1;
            this.chooseSongButton.Text = "Add Songs";
            this.chooseSongButton.UseVisualStyleBackColor = true;
            this.chooseSongButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.playButton.Location = new System.Drawing.Point(508, 501);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(105, 51);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.stopButton.Location = new System.Drawing.Point(649, 501);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(105, 51);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 584);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.chooseSongButton);
            this.Controls.Add(this.songList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button chooseSongButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
    }
}

