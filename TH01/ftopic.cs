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
    public partial class ftopic : Form
    {
        public string tp;
        string name="hihi";
        public ftopic()
        {
            InitializeComponent();
            
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {

        }

        private void skinButton4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fstart fm = new fstart();
            fm.Show();
            this.Hide();
        }

        private void pb_close1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi trò chơi", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
                name = textBox5.Text.Replace(" ", string.Empty);
            tp = "f";
            fvo_play fm = new fvo_play(tp,name);
            fm.Show();
            this.Hide();
        }

        private void skinButton2_Click_1(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
                name = textBox5.Text.Replace(" ", string.Empty);
            tp = "a";

            fvo_play fm = new fvo_play(tp,name);
            fm.Show();
            this.Hide();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
                name = textBox5.Text.Replace(" ", string.Empty);
            tp = "c";
            fvo_play fm = new fvo_play(tp,name);
            fm.Show();
            this.Hide();
        }

        private void skinButton4_Click_1(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
                name = textBox5.Text.Replace(" ", string.Empty);
            tp = "l";
            fvo_play fm = new fvo_play(tp,name);
            fm.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
