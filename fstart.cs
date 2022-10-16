using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH01
{
    public partial class fstart : Form
    {
        public fstart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       

        private void pb_vocab_Click(object sender, EventArgs e)
        {
            fvo fm = new fvo();
            fm.Show(this);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        

        private void pb_close1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi trò chơi", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picturebox_play1_Click(object sender, EventArgs e)
        {
            ftopic fm = new ftopic();
            fm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frank fm = new frank();
            fm.Show(this);
        }
    }
}
