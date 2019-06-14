namespace Democrazik
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BPath = new System.Windows.Forms.Button();
            this.BPause = new System.Windows.Forms.Button();
            this.BStop = new System.Windows.Forms.Button();
            this.BPlay = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.BNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // BPath
            // 
            this.BPath.Location = new System.Drawing.Point(316, 10);
            this.BPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BPath.Name = "BPath";
            this.BPath.Size = new System.Drawing.Size(56, 19);
            this.BPath.TabIndex = 0;
            this.BPath.Text = "Browse";
            this.BPath.UseVisualStyleBackColor = true;
            this.BPath.Click += new System.EventHandler(this.BPath_Click);
            // 
            // BPause
            // 
            this.BPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BPause.Location = new System.Drawing.Point(242, 10);
            this.BPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BPause.Name = "BPause";
            this.BPause.Size = new System.Drawing.Size(56, 19);
            this.BPause.TabIndex = 1;
            this.BPause.Text = "Pause";
            this.BPause.UseVisualStyleBackColor = false;
            this.BPause.Click += new System.EventHandler(this.BPause_Click);
            // 
            // BStop
            // 
            this.BStop.BackColor = System.Drawing.Color.Red;
            this.BStop.Location = new System.Drawing.Point(169, 10);
            this.BStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BStop.Name = "BStop";
            this.BStop.Size = new System.Drawing.Size(56, 19);
            this.BStop.TabIndex = 2;
            this.BStop.Text = "Stop";
            this.BStop.UseVisualStyleBackColor = false;
            this.BStop.Click += new System.EventHandler(this.BStop_Click);
            // 
            // BPlay
            // 
            this.BPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BPlay.Location = new System.Drawing.Point(96, 10);
            this.BPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BPlay.Name = "BPlay";
            this.BPlay.Size = new System.Drawing.Size(56, 19);
            this.BPlay.TabIndex = 3;
            this.BPlay.Text = "Play";
            this.BPlay.UseVisualStyleBackColor = false;
            this.BPlay.Click += new System.EventHandler(this.BPlay_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 41);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 316);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Music Controls :";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(600, 10);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(17, 24);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // BNext
            // 
            this.BNext.Location = new System.Drawing.Point(388, 333);
            this.BNext.Name = "BNext";
            this.BNext.Size = new System.Drawing.Size(75, 23);
            this.BNext.TabIndex = 8;
            this.BNext.Text = "Nextpage";
            this.BNext.UseVisualStyleBackColor = true;
            this.BNext.Click += new System.EventHandler(this.BNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(472, 366);
            this.Controls.Add(this.BNext);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BPlay);
            this.Controls.Add(this.BStop);
            this.Controls.Add(this.BPause);
            this.Controls.Add(this.BPath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPath;
        private System.Windows.Forms.Button BPause;
        private System.Windows.Forms.Button BStop;
        private System.Windows.Forms.Button BPlay;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button BNext;
    }
}