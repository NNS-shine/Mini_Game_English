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
    public partial class frank : Form
    {
        string topic = "f";
        public frank()
        {
            InitializeComponent();
            rank();
        }

        public void rank()
        {
            string rankurl = "./rank" + topic+ ".txt";
            string[] Datade = System.IO.File.ReadAllLines(rankurl);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("score", typeof(int));
            dt.Columns.Add("time", typeof(string));
            for (int i = 0; i < Datade.Length; i++)
            {
                string[] a = Datade[i].Split(' ');
                dt.Rows.Add(a[0], Convert.ToDouble(a[1]));
            }
            dt.DefaultView.Sort = "score DESC";
            dt = dt.DefaultView.ToTable();
            button1.Text = dt.Rows[0]["ID"] + "  " + dt.Rows[0]["score"].ToString() + "  " + dt.Rows[0]["time"].ToString();
            button2.Text = dt.Rows[1]["ID"] + "  " + dt.Rows[1]["score"].ToString() + "  " + dt.Rows[1]["time"].ToString();
            button3.Text = dt.Rows[2]["ID"] + "  " + dt.Rows[2]["score"].ToString() + "  " + dt.Rows[2]["time"].ToString();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frank_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            topic = "fruit";
            skinButton1.ForeColor = Color.Yellow;
            skinButton2.ForeColor = Color.White;
            skinButton3.ForeColor = Color.White;
            skinButton4.ForeColor = Color.White;
            rank();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            topic = "animal";
            skinButton2.ForeColor = Color.Yellow;
            skinButton1.ForeColor = Color.White;
            skinButton3.ForeColor = Color.White;
            skinButton4.ForeColor = Color.White;
            rank();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            topic = "clothes";
            skinButton3.ForeColor = Color.Yellow;
            skinButton2.ForeColor = Color.White;
            skinButton1.ForeColor = Color.White;
            skinButton4.ForeColor = Color.White;
            rank();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            topic = "class";
            skinButton4.ForeColor = Color.Yellow;
            skinButton2.ForeColor = Color.White;
            skinButton3.ForeColor = Color.White;
            skinButton1.ForeColor = Color.White;
            rank();
        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
