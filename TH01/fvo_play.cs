using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Reflection;
using System.Timers;
using System.Threading;


namespace TH01
{

    public partial class fvo_play : Form
    {

        int m = 0;
        int s = 0;
        int socau = 0;
        int count = 0;
        int idx = 1;
        int score = 0;
        int num_vo = 10;
        string[] ans;
        string tp = "f";
        string ten = "hihi";
        ResourceManager rm = new ResourceManager("TH01.Properties.Resources", Assembly.GetExecutingAssembly());
        Random rd = new Random();
        private string gamepath;
        int[] values = Enumerable.Repeat(1, 11).ToArray();

        public fvo_play(string topic,string name)
        {
            InitializeComponent();
            axWindowsMediaPlayerwrong.URL = "incorrect.mp4";
            axWindowsMediaPlayertrue.URL = "correct.mp4";
            axWindowsMediaPlayerwrong.Ctlcontrols.stop();
            axWindowsMediaPlayertrue.Ctlcontrols.stop();

            label8.Text = count.ToString() + " / " + "5";
            label7.Text = score.ToString();
            ten = name;
            tp = topic;
            if (tp == "f")
                gamepath = "./Fruit.txt";
            if (tp == "a")
                gamepath = "./Animal.txt";
            if (tp == "c")
                gamepath = "./Clothes.txt";
            if (tp == "l")
                gamepath = "./Classroom.txt";
            ans = File.ReadAllLines(gamepath);
        }

        public void answer(string s, int idx)
        {

            socau++;
            if (s == ans[idx - 1])
            {
                axWindowsMediaPlayertrue.Ctlcontrols.play();
                pictureBox7.Visible = true;
                score++;
                count++;
            }
            else
            {
                label9.Text = ans[idx - 1];
                axWindowsMediaPlayerwrong.Ctlcontrols.play();
                pictureBox8.Visible = true;
            }
            label8.Text = count.ToString() + " / " + "5";
            label7.Text = score.ToString();
            int r = 5;
            if (socau == r)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                timer1.Enabled = false;
                this.Hide();
                string line = ten + " " + score.ToString();
                string[] lines =
                {
                    line
                };
                string saveurl = "./rank" + tp + ".txt";
                File.AppendAllLines(saveurl, lines);
            }
           
            Application.DoEvents();
            Thread.Sleep(1000);
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void LoadImages()
        {
            textBox1.Text = "";
            textBox1.Select();

            do
            {
                idx = rd.Next(1, num_vo + 1);
            } while (values[idx] != 1);
            values[idx] = 0;
            string id = tp + idx.ToString();
            this.pictureBox3.Image = (Image)rm.GetObject(id);
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            axWindowsMediaPlayer1.URL = "Phonix_song.mp4";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fstart fm = new fstart();
            fm.Show();
            this.Hide();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ftopic fm = new ftopic();
            fm.Show();
            this.Hide();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pb_close1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi trò chơi", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            textBox1.Visible = true;
            label9.Visible = true;
            pictureBox3.Visible = true; ;
            pictureBox9.Visible = true;
            pictureBox6.Hide();
            label2.Hide();
            timer1.Enabled = true;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            label1.Text = m.ToString() + ":" + s.ToString();
            LoadImages();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            s += 1;
            if (s == 60)
            {
                m += 1;
                s = 0;
            }
            if (m == 60)
                timer1.Stop();
            label1.Text = m.ToString() + ":" + s.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            answer(textBox1.Text, idx);
            label9.Text = "";
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            fend ft = new fend(tp,score,ten,m,s);
            int r = 5;
            if (socau == r)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                timer1.Enabled = false;
                this.Hide();
                ft.Show();
            }
           else
            {
                do
                {
                    idx = rd.Next(1, num_vo + 1);
                } while (values[idx] != 1);
                values[idx] = 0;
                string id = tp + idx.ToString();
                this.pictureBox3.Image = (Image)rm.GetObject(id);
            }
            textBox1.Text = "";
            textBox1.Select();
        }


        private void axWindowsMediaPlayer3_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
