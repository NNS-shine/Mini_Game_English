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
    public partial class fvo_class : Form
    {
        public fvo_class()
        {
            InitializeComponent();
        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("English", typeof(string));
            dt.Columns.Add("Vietnamese", typeof(string));
            dt.Rows.Add("1", "Pencil ", "Bút chì");
            dt.Rows.Add("2", "Eraser", "Tẩy");
            dt.Rows.Add("3", "Chair", "Ghế");
            dt.Rows.Add("4", "Dictionary", "Từ điển");
            dt.Rows.Add("5", "Map", "Bản đồ");
            dt.Rows.Add("6", "Ruler", "Thước kẻ");
            dt.Rows.Add("7", "Pen", "Bút mực");
            dt.Rows.Add("8", "Bag", "Cặp sách");
            dt.Rows.Add("9", "Book", "Sách");
            dt.Rows.Add("10", "Blackboard", "Bảng đen");
            dataGridView1.DataSource = dt;
        }
    }
}
