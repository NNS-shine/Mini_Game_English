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
    public partial class fvo_fruit : Form
    {
        public fvo_fruit()
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

        private void Form3_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("English", typeof(string));
            dt.Columns.Add("Vietnamese", typeof(string));
            dt.Rows.Add("1", "Mango", "Xoài");
            dt.Rows.Add("2", "Apple", "Táo");
            dt.Rows.Add("3", "Banana", "Chuối");
            dt.Rows.Add("4", "Coconut", "Dừa");
            dt.Rows.Add("5", "Pineapple", "Dứa");
            dt.Rows.Add("6", "Orange", "Cam");
            dt.Rows.Add("7", "Avocado ", "Bơ");
            dt.Rows.Add("8", "Lemon ", "Chanh vàng");
            dt.Rows.Add("9", "Watermelon", "Dưa hấu");
            dt.Rows.Add("10", "Strawberry ", "Dâu tây");
            dataGridView1.DataSource = dt;
        }
    }
}
