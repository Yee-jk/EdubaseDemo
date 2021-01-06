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
    public partial class BookOrder : Form
    {
        public BookOrder()
        {
            InitializeComponent();
        }
        private void LoadBook()
        {
            if (cb_Term.SelectedItem.ToString() == "2020-2021-1")
            {
                string Search = $@"SELECT *
                                From tb_Book AS B
                                WHERE B.Term='2020-2021-1';";
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickRead(Search);
                while (sqlHelper.HasRecord)
                {
                    int index = this.dgv_Book.Rows.Add();
                    dgv_Book.Rows[index].Cells[0].Value = sqlHelper["Term"].ToString();
                    dgv_Book.Rows[index].Cells[1].Value = sqlHelper["CourseNo"].ToString();
                    dgv_Book.Rows[index].Cells[2].Value = sqlHelper["CourseName"].ToString();
                    dgv_Book.Rows[index].Cells[3].Value = sqlHelper["ISBN"].ToString();
                    dgv_Book.Rows[index].Cells[4].Value = sqlHelper["BookName"].ToString();
                    dgv_Book.Rows[index].Cells[5].Value = sqlHelper["Writer"].ToString();
                    dgv_Book.Rows[index].Cells[6].Value = sqlHelper["Publish"].ToString();
                    dgv_Book.Rows[index].Cells[7].Value = sqlHelper["Price"].ToString();
                    dgv_Book.Rows[index].Cells[8].Value = sqlHelper["IfUse"].ToString();
                    dgv_Book.Rows[index].Cells[9].Value = sqlHelper["IfSubscribe"].ToString();
                }
            }
            else
            {
                string Search = $@"SELECT *
                                From tb_Book AS B
                                WHERE B.Term='2020-2021-2';";
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickRead(Search);
                while (sqlHelper.HasRecord)
                {
                    int index = this.dgv_Book.Rows.Add();
                    dgv_Book.Rows[index].Cells[0].Value = sqlHelper["Term"].ToString();
                    dgv_Book.Rows[index].Cells[1].Value = sqlHelper["CourseNo"].ToString();
                    dgv_Book.Rows[index].Cells[2].Value = sqlHelper["CourseName"].ToString();
                    dgv_Book.Rows[index].Cells[3].Value = sqlHelper["ISBN"].ToString();
                    dgv_Book.Rows[index].Cells[4].Value = sqlHelper["BookName"].ToString();
                    dgv_Book.Rows[index].Cells[5].Value = sqlHelper["Writer"].ToString();
                    dgv_Book.Rows[index].Cells[6].Value = sqlHelper["Publish"].ToString();
                    dgv_Book.Rows[index].Cells[7].Value = sqlHelper["Price"].ToString();
                    dgv_Book.Rows[index].Cells[8].Value = sqlHelper["IfUse"].ToString();
                    dgv_Book.Rows[index].Cells[9].Value = sqlHelper["IfSubscribe"].ToString();
                }
            }
        }
        private void BookOrder_Load(object sender, EventArgs e)
        {
            this.dgv_Book.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            gb_Term.Visible = false;
            dgv_Book.Visible = true;
            dgv_Book.Rows.Clear();
            this.LoadBook();
        }

        private void dgv_Book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string IFSubscribe = this.dgv_Book.CurrentRow.Cells["IFSubscribe"].Value.ToString();
            if (IFSubscribe=="订购")
            {
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickSubmit($@"UPDATE tb_Book	SET	IfSubscribe='退订',IfUse='是'
                                        FROM tb_Book AS B	
	                                    WHERE B.ISBN='{this.dgv_Book.CurrentRow.Cells["ISBN"].Value.ToString()}';");
                dgv_Book.Rows.Clear();
                this.LoadBook();
            }
            else
            {
                SqlHelper sqlHelper = new SqlHelper();
                sqlHelper.QuickSubmit($@"UPDATE tb_Book	SET	IfSubscribe='订购',IfUse='否'
                                        FROM tb_Book AS B	
	                                    WHERE B.ISBN='{this.dgv_Book.CurrentRow.Cells["ISBN"].Value.ToString()}';");
                dgv_Book.Rows.Clear();
                this.LoadBook();
            }
        }
    }
}
