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
    public partial class fvo_clothes : Form
    {
        public fvo_clothes()
        {
            InitializeComponent();
        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
             DataTable dt = new DataTable();
             dt.Columns.Add("ID", typeof(string));
             dt.Columns.Add("English", typeof(string));
             dt.Columns.Add("Vietnamese", typeof(string));
             dt.Rows.Add("1", "Hat ", "Mũ");
             dt.Rows.Add("2", "T-shirt", "Áo thun");
             dt.Rows.Add("3", "Jacket", "Áo khoác");
             dt.Rows.Add("4", "Dress", "Đầm");
             dt.Rows.Add("5", "Tie", "Cà vạt");
             dt.Rows.Add("6", "Sweater", "Áo len");
             dt.Rows.Add("7", "Pajamas", "Đồ ngủ");
             dt.Rows.Add("8", "Shoes", "Giày");
             dt.Rows.Add("9", "Glasses", "Mắt kính");
             dt.Rows.Add("10", "Watch", "Đồng hồ");
             dataGridView1.DataSource = dt;
        }
    }
}
