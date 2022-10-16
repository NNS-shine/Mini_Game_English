
namespace TH01
{
    partial class fvo
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
            this.btn_close2 = new DotNetSkin.SkinControls.SkinButton();
            this.skinButton1 = new DotNetSkin.SkinControls.SkinButton();
            this.skinButton2 = new DotNetSkin.SkinControls.SkinButton();
            this.skinButton3 = new DotNetSkin.SkinControls.SkinButton();
            this.skinButton4 = new DotNetSkin.SkinControls.SkinButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_close2
            // 
            this.btn_close2.BackColor = System.Drawing.Color.White;
            this.btn_close2.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close2.ForeColor = System.Drawing.Color.Red;
            this.btn_close2.Location = new System.Drawing.Point(198, 433);
            this.btn_close2.Name = "btn_close2";
            this.btn_close2.Size = new System.Drawing.Size(90, 44);
            this.btn_close2.TabIndex = 0;
            this.btn_close2.Tag = "";
            this.btn_close2.Text = "Close";
            this.btn_close2.UseVisualStyleBackColor = false;
            this.btn_close2.Click += new System.EventHandler(this.btn_close2_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.SystemColors.Control;
            this.skinButton1.Font = new System.Drawing.Font("Sitka Text", 10.8F);
            this.skinButton1.Location = new System.Drawing.Point(95, 96);
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.Size = new System.Drawing.Size(135, 139);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.Text = "FRUIT";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.Font = new System.Drawing.Font("Sitka Text", 10.8F);
            this.skinButton2.Location = new System.Drawing.Point(257, 96);
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.Size = new System.Drawing.Size(135, 139);
            this.skinButton2.TabIndex = 3;
            this.skinButton2.Text = "ANIMAL";
            this.skinButton2.UseVisualStyleBackColor = true;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton3
            // 
            this.skinButton3.Font = new System.Drawing.Font("Sitka Text", 10.8F);
            this.skinButton3.Location = new System.Drawing.Point(95, 263);
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.Size = new System.Drawing.Size(135, 139);
            this.skinButton3.TabIndex = 4;
            this.skinButton3.Text = "CLOTHES";
            this.skinButton3.UseVisualStyleBackColor = true;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // skinButton4
            // 
            this.skinButton4.Font = new System.Drawing.Font("Sitka Text", 10.8F);
            this.skinButton4.Location = new System.Drawing.Point(257, 263);
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.Size = new System.Drawing.Size(135, 139);
            this.skinButton4.TabIndex = 5;
            this.skinButton4.Text = "CLASSROOM";
            this.skinButton4.UseVisualStyleBackColor = true;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.textBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox1.Location = new System.Drawing.Point(209, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 32);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "TOPIC";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TH01.Properties.Resources._21152189;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 541);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.skinButton4);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.btn_close2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotNetSkin.SkinControls.SkinButton btn_close2;
        private DotNetSkin.SkinControls.SkinButton skinButton1;
        private DotNetSkin.SkinControls.SkinButton skinButton2;
        private DotNetSkin.SkinControls.SkinButton skinButton3;
        private DotNetSkin.SkinControls.SkinButton skinButton4;
        private System.Windows.Forms.TextBox textBox1;
    }
}