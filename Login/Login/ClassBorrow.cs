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
    public partial class ClassBorrow : Form
    {
        public ClassBorrow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClassBorrow_Load(object sender, EventArgs e)
        {
            cb_Term.SelectedItem = "2020-2021-1";
            cb_Building.SelectedItem = "---请选择---";
            cb_Department.SelectedItem = "---请选择---";
            cb_WeekStart.SelectedItem=cb_WeekEnd.SelectedItem = "请选择";
            cb_DayStart.SelectedItem=cb_DayEnd.SelectedItem = "请选择";
            cb_SectionStart.SelectedItem=cb_SectionEnd.SelectedItem= "请选择";
            cb_WeekEnd.SelectedItem = "请选择";
        }

        private void cb_Building_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ClassRoom.Items.Clear();
            string Search = $@"SELECT
	                            CR.ClassNumber FROM
                            tb_ClassRoom  AS CR WHERE
                              CR.BuildingName='{cb_Building.SelectedItem.ToString()}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            while (sqlHelper.HasRecord)
            {
                cb_ClassRoom.Items.Add(sqlHelper["ClassNumber"].ToString());
            }

        }
        private void Search()
        {
            string Search1 = $@"SELECT
	                            CB.Term
	                            ,CB.BUilding
	                            ,CB.Room
	                            ,CB.Department
	                            ,IIF(CB.WeekEnd IS NULL,CB.WeekStart,CB.WeekStart+'至'+CB.WeekEnd) AS Week
	                            ,IIF(CB.DayEnd IS NULL,CB.DayStart,CB.DayStart+'至'+CB.DayEnd) AS Day
	                            ,IIF(CB.SectionEnd IS NULL,CB.SectionStart,CB.SectionStart+'至'+CB.SectionEnd) AS Section
                            FROM
                            dbo.tb_ClassBorrow	 AS CB;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search1);
            while (sqlHelper.HasRecord)
            {
                int index = this.dgv_ClassBorrow.Rows.Add();
                dgv_ClassBorrow.Rows[index].Cells[0].Value = sqlHelper["Term"].ToString();
                dgv_ClassBorrow.Rows[index].Cells[1].Value = sqlHelper["BUilding"].ToString();
                dgv_ClassBorrow.Rows[index].Cells[2].Value = sqlHelper["Room"].ToString();
                dgv_ClassBorrow.Rows[index].Cells[3].Value = sqlHelper["Department"].ToString();
                dgv_ClassBorrow.Rows[index].Cells[4].Value = sqlHelper["Week"].ToString();
                dgv_ClassBorrow.Rows[index].Cells[5].Value = sqlHelper["Day"].ToString();
                dgv_ClassBorrow.Rows[index].Cells[6].Value = sqlHelper["Section"].ToString();
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_ClassBorrow.Rows.Clear();
            this.Search();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickSubmit($@"INSERT dbo.tb_ClassBorrow
                (Term,BUilding, Room,Department,WeekStart,WeekEnd,DayStart,DayEnd,SectionStart,SectionEnd)
            VALUES
            ('{cb_Term.SelectedItem.ToString()}', '{cb_Building.SelectedItem.ToString()}', '{cb_ClassRoom.SelectedItem.ToString()}',
                '{cb_Department.SelectedItem.ToString()}', '{cb_WeekStart.SelectedItem.ToString()}', '{cb_WeekEnd.SelectedItem.ToString()}',
                '{cb_DayStart.SelectedItem.ToString()}', '{cb_DayEnd.SelectedItem.ToString()}', '{cb_SectionStart.SelectedItem.ToString()}', '{cb_SectionEnd.ToString()}'); ");
            dgv_ClassBorrow.Rows.Clear();
            this.Search();
        }
        private void cb_Department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       
        private void cb_WeekEnd_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void cb_DayEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_SectionEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
