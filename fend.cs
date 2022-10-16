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
    public partial class fend : Form
    {
        string c, ten;
        int m, s;
        public fend(string a,double diem, string name,int p, int g )
        {
            InitializeComponent();

            label7.Text = Math.Round(diem, 1).ToString();
            label3.Text= p.ToString() + ":" + g.ToString();
            ten = name;
            c = a;
            m = p;
            s = g;
        }
        private void fend_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_close1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi trò chơi", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            frank fm = new frank();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            ftopic fm = new ftopic();
            this.Hide();
            fm.Show();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            fvo_play fm = new fvo_play(c,ten);
            this.Hide();
            fm.Show();
        }
    }
}
