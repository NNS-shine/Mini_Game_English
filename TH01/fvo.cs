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
    public partial class fvo : Form
    {
        public fvo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {

        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            fvo_clothes fm = new fvo_clothes();
            fm.Show(this);
           
        }

        private void skinButton4_Click_1(object sender, EventArgs e)
        {
            fvo_class fm =new fvo_class();
            fm.Show(this);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            fvo_fruit fm = new fvo_fruit();
            fm.Show(this);
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            fvo_animal fm = new fvo_animal();
            fm.Show(this);
        }
    }
}
