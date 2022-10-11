
namespace TH01
{
    partial class fstart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fstart));
            this.pb_vocab = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.picturebox_play1 = new System.Windows.Forms.PictureBox();
            this.pb_close1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vocab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_play1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_vocab
            // 
            this.pb_vocab.Image = global::TH01.Properties.Resources._7479650_literature_literature_review_search_find_read_icon;
            this.pb_vocab.Location = new System.Drawing.Point(2, 0);
            this.pb_vocab.Name = "pb_vocab";
            this.pb_vocab.Size = new System.Drawing.Size(48, 48);
            this.pb_vocab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_vocab.TabIndex = 4;
            this.pb_vocab.TabStop = false;
            this.pb_vocab.Click += new System.EventHandler(this.pb_vocab_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TH01.Properties.Resources._3672883_award_certificate_education_emblem_medal_icon;
            this.pictureBox6.Location = new System.Drawing.Point(2, 64);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox7.Image = global::TH01.Properties.Resources.tải_xuống__1_;
            this.pictureBox7.Location = new System.Drawing.Point(474, 126);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(211, 206);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // picturebox_play1
            // 
            this.picturebox_play1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picturebox_play1.BackColor = System.Drawing.Color.White;
            this.picturebox_play1.Image = global::TH01.Properties.Resources._728948_control_device_game_joypad_playing_icon;
            this.picturebox_play1.Location = new System.Drawing.Point(278, 178);
            this.picturebox_play1.Name = "picturebox_play1";
            this.picturebox_play1.Size = new System.Drawing.Size(162, 124);
            this.picturebox_play1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_play1.TabIndex = 7;
            this.picturebox_play1.TabStop = false;
            this.picturebox_play1.Click += new System.EventHandler(this.picturebox_play1_Click);
            // 
            // pb_close1
            // 
            this.pb_close1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_close1.Image = global::TH01.Properties.Resources._1398919_close_cross_incorrect_invalid_x_icon;
            this.pb_close1.Location = new System.Drawing.Point(965, 0);
            this.pb_close1.Name = "pb_close1";
            this.pb_close1.Size = new System.Drawing.Size(35, 37);
            this.pb_close1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close1.TabIndex = 0;
            this.pb_close1.TabStop = false;
            this.pb_close1.Click += new System.EventHandler(this.pb_close1_Click);
            // 
            // fstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TH01.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.picturebox_play1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pb_vocab);
            this.Controls.Add(this.pb_close1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fstart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_vocab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_play1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_vocab;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox picturebox_play1;
        private System.Windows.Forms.PictureBox pb_close1;
    }
}

