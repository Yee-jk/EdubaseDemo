using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace Login
{
    public partial class StudentBookChoose : Form
    {
        public StudentBookChoose()
        {
            InitializeComponent();
        }

        private void StudentBookChoose_Load(object sender, EventArgs e)
        {
            dgv_BookChoose.Rows.Clear();
            string Search = $@"SELECT *
                                From tb_Book AS B
                                WHERE B.IfUse='是';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            while (sqlHelper.HasRecord)
            {
                int index = this.dgv_BookChoose.Rows.Add();
                dgv_BookChoose.Rows[index].Cells[0].Value = sqlHelper["Term"].ToString();
                dgv_BookChoose.Rows[index].Cells[1].Value = sqlHelper["CourseNo"].ToString();
                dgv_BookChoose.Rows[index].Cells[2].Value = sqlHelper["CourseName"].ToString();
                dgv_BookChoose.Rows[index].Cells[3].Value = sqlHelper["ISBN"].ToString();
                dgv_BookChoose.Rows[index].Cells[4].Value = sqlHelper["BookName"].ToString();
                dgv_BookChoose.Rows[index].Cells[5].Value = sqlHelper["Writer"].ToString();
                dgv_BookChoose.Rows[index].Cells[6].Value = sqlHelper["Publish"].ToString();
                dgv_BookChoose.Rows[index].Cells[7].Value = sqlHelper["Price"].ToString();
                dgv_BookChoose.Rows[index].Cells[8].Value = sqlHelper["IfUse"].ToString();
                dgv_BookChoose.Rows[index].Cells[9].Value = sqlHelper["IfSubscribe"].ToString();
            }
        }
    }
}
