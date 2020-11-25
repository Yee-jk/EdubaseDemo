using System;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace Login
{
    public partial class Center : Form
    {       
        public Center()
        {
            InitializeComponent();
        }

        private void dgv_Notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tab_MyDesk_Click(object sender, EventArgs e)
        {

        }

        private void Center_Load(object sender, EventArgs e)
        {
            dgv_LeaveMessage.Visible = false;
            gb_LeaveMessage.Visible = false;
            gb_Notice.Visible = false;
            groupBox2.Visible = false;
            gb_ModifyCode.Visible = false;
            dgv_WarnQuary.Visible = false;
            dgv_Transaction.Visible = false;
            dgv_ScoreInquiry.Visible = false;
            gb_ScoreInquiry.Visible = false;
            tb_Show.Text = "增加";
            string Search = @"SELECT
                                *
                            FROM
	                            tb_TrainProgram	AS TP;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            while (sqlHelper.HasRecord)
            {
                int index = this.dgv_TrainProgram.Rows.Add();
                dgv_TrainProgram.Rows[index].Cells[0].Value = sqlHelper["No"].ToString();
                dgv_TrainProgram.Rows[index].Cells[1].Value = sqlHelper["Title"].ToString();
                dgv_TrainProgram.Rows[index].Cells[2].Value = sqlHelper["Operation"].ToString();
            }
        }

        private void Btn_Notice_Click(object sender, EventArgs e)
        {
            dgv_LeaveMessage.Visible = false;
            dgv_Notice.Visible = true;
            gb_LeaveMessage.Visible = false;
            gb_Notice.Visible = true;
            groupBox2.Visible = false;
            gb_ModifyCode.Visible = false;
            string Search1 = @"SELECT
                            *
                           FROM
                            dbo.tb_Notice AS N; ";
            SqlHelper sqlHelper1 = new SqlHelper();
            sqlHelper1.QuickRead(Search1);
            while(sqlHelper1.HasRecord)
            {
                int index1 = this.dgv_Notice.Rows.Add();
                dgv_Notice.Rows[index1].Cells[0].Value = sqlHelper1["No"].ToString();
                dgv_Notice.Rows[index1].Cells[1].Value = sqlHelper1["Title"].ToString();
                dgv_Notice.Rows[index1].Cells[2].Value = sqlHelper1["Type"].ToString();
                dgv_Notice.Rows[index1].Cells[3].Value = sqlHelper1["Sender"].ToString();
                dgv_Notice.Rows[index1].Cells[4].Value = sqlHelper1["SendTime"].ToString();
            }
        }

        private void Btn_Leavemessage_Click(object sender, EventArgs e)
        {
            dgv_Notice.Visible = false;
            dgv_LeaveMessage.Visible = true;
            gb_Notice.Visible = false;
            gb_LeaveMessage.Visible = true;
            groupBox2.Visible = false;
            gb_ModifyCode.Visible = false;
            string Search4 = @"SELECT
                            *
                           FROM
                            dbo.tb_LeaveMessage AS L
                           WHERE
                              L.No='1'; ";
            SqlHelper sqlHelper4 = new SqlHelper();
            sqlHelper4.QuickRead(Search4);
            if (sqlHelper4.HasRecord)
            {
                int index4 = this.dgv_LeaveMessage.Rows.Add();
                dgv_LeaveMessage.Rows[index4].Cells[0].Value = sqlHelper4["No"].ToString();
                dgv_LeaveMessage.Rows[index4].Cells[1].Value = sqlHelper4["Title"].ToString();
                dgv_LeaveMessage.Rows[index4].Cells[2].Value = sqlHelper4["Type"].ToString();
                dgv_LeaveMessage.Rows[index4].Cells[3].Value = sqlHelper4["Sender"].ToString();
                dgv_LeaveMessage.Rows[index4].Cells[4].Value = sqlHelper4["Sendtime"].ToString();
            }
            }     
        private void gb_Notice_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gb_LeaveMessage_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button28_Click(object sender, EventArgs e)
        {

        }       
        private void b_Click(object sender, EventArgs e)
        {
            dgv_Notice.Visible = false;
            dgv_LeaveMessage.Visible = false;
            gb_Notice.Visible = false;
            gb_LeaveMessage.Visible = false;
            groupBox2.Visible = true;
            gb_ModifyCode.Visible = false;
            string Search = $@"SELECT
		                    SC.No
	                        ,SC.Name
	                        FROM dbo.tb_StudentCard AS SC
                            WHERE
		                   No='3190707045';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            if (sqlHelper.HasRecord)
            {
                this.LoginIn_Id.Text = sqlHelper["No"].ToString();
                this.TrueName.Text = sqlHelper["Name"].ToString();                
            }
        }

        private void Btn_Preserve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("保存成功！");
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Question1.Text = "";
            Response1.Text = "";
            Question2.Text = "";
            Response2.Text = "";
        }

        private void btn_ModifyCode_Click(object sender, EventArgs e)
        {
            dgv_Notice.Visible = false;
            dgv_LeaveMessage.Visible = false;
            gb_Notice.Visible = false;
            gb_LeaveMessage.Visible = false;
            gb_ModifyCode.Visible = true;
            groupBox2.Visible = false;
            gb_ModifyCode.Visible = true;
            string Search = $@"SELECT
		                    S.No
	                        ,S.Code
	                        FROM dbo.tb_Student AS S
                            WHERE
		                   No='3190707045';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            if (sqlHelper.HasRecord)
            {
                this.tb_ID.Text = sqlHelper["No"].ToString();               
            }
        }

        private void gb_ModifyCode_Enter(object sender, EventArgs e)
        {

        }

        private void btn_preserve2_Click(object sender, EventArgs e)
        {
            string Search = $@"SELECT
		                    S.No
	                        ,S.Code
	                        FROM dbo.tb_Student AS S
                            WHERE
		                   No='3190707045';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            if (sqlHelper.HasRecord)
            {
                string code = sqlHelper["Code"].ToString();
                if (code!=tb_OldCode.Text.ToString())
                {
                    MessageBox.Show("旧密码输入有误！");
                }
                else
                {
                    if (tb_NewCode.Text.ToString() != tb_ConfirmNewCode.Text.ToString())
                    {
                        MessageBox.Show("两次新密码不一致！");
                    }
                    else
                    {
                        MessageBox.Show("保存成功！");
                    }
                }
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_WarnQuary_Click(object sender, EventArgs e)
        {
            dgv_WarnQuary.Visible = true;
            dgv_Transaction.Visible = false;
            dgv_ScoreInquiry.Visible = false;
            gb_ScoreInquiry.Visible = false;           
            tb_Show.Visible = false;
            dgv_infoManagement.Visible = false;
        }

        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            dgv_WarnQuary.Visible = false;
            dgv_Transaction.Visible = true;
            dgv_ScoreInquiry.Visible = false;
            gb_ScoreInquiry.Visible = false;
            dgv_infoManagement.Visible = false;
            tb_Show.Visible = true;
            tb_Show.Text="申请异动";
        }

        private void btn_ScoreInquiry_Click(object sender, EventArgs e)
        {
            dgv_WarnQuary.Visible = false;
            dgv_Transaction.Visible = false;
            dgv_ScoreInquiry.Visible = false;
            gb_ScoreInquiry.Visible = true;
            dgv_infoManagement.Visible = false;
            tb_Show.Visible = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_ScoreInquiry.Visible = true;
            gb_ScoreInquiry.Visible = false;
            String Search = $@"SELECT
                                *
                            FROM
	                            dbo.tb_CourseGrade;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            while (sqlHelper.HasRecord)
            {
                int index = this.dgv_ScoreInquiry.Rows.Add();
                dgv_ScoreInquiry.Rows[index].Cells[0].Value = sqlHelper["Term"].ToString();
                dgv_ScoreInquiry.Rows[index].Cells[1].Value = sqlHelper["CourseNo"].ToString();
                dgv_ScoreInquiry.Rows[index].Cells[2].Value = sqlHelper["CourseName"].ToString();
                dgv_ScoreInquiry.Rows[index].Cells[3].Value = sqlHelper["Grade"].ToString();
                dgv_ScoreInquiry.Rows[index].Cells[4].Value = sqlHelper["Credit"].ToString();
                dgv_ScoreInquiry.Rows[index].Cells[5].Value = sqlHelper["TotalHour"].ToString();
                dgv_ScoreInquiry.Rows[index].Cells[6].Value = sqlHelper["ExamWay"].ToString();
                dgv_ScoreInquiry.Rows[index].Cells[7].Value = sqlHelper["CourseAttribute"].ToString();
                dgv_ScoreInquiry.Rows[index].Cells[8].Value = sqlHelper["CourseNature"].ToString();
            }
        }

        private void btn_infoManagement_Click(object sender, EventArgs e)
        {
            dgv_WarnQuary.Visible = false;
            dgv_Transaction.Visible = false;
            dgv_ScoreInquiry.Visible = false;
            gb_ScoreInquiry.Visible = false;
            dgv_infoManagement.Visible = true;
            tb_Show.Visible = true;
            tb_Show.Text = "增加";

        }

        private void dgv_LeaveMessage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cb_StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void btn_Reset2_Click(object sender, EventArgs e)
        {
            tb_OldCode.Text = "";
            tb_NewCode.Text = "";
            tb_ConfirmNewCode.Text = "";
        }

        private void btn_TeachingWeek_Click(object sender, EventArgs e)
        {
            TeachingWeek teachingWeek = new TeachingWeek();
            teachingWeek.Show();
        }
    }
    }
