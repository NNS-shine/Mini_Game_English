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
    public partial class fvo_animal : Form
    {
        public fvo_animal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btn_close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("English", typeof(string));
            dt.Columns.Add("Vietnamese", typeof(string));
            dt.Rows.Add("1", "Dog", "Chó ");
            dt.Rows.Add("2", "Cat", "Mèo");
            dt.Rows.Add("3", "Mouse", "Chuột ");
            dt.Rows.Add("4", "Duck", "Vịt");
            dt.Rows.Add("5", "Pig", "Heo ");
            dt.Rows.Add("6", "Chicken", "Gà ");
            dt.Rows.Add("7", "Fish", "Cá");
            dt.Rows.Add("8", "Monkey", "Khỉ ");
            dt.Rows.Add("9", "Snake", "Rắn ");
            dt.Rows.Add("10", "Bee", "Ong");
            dataGridView1.DataSource = dt;
        }
    }
}
