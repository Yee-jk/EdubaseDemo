using System;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace Login
{
    public partial class Center : Form
    {
        private string Studentid;
        public Center()
        {
            InitializeComponent();
        }
        public Center(String StudentNo) : this()
        {
            Studentid = StudentNo;
        }

        private void dgv_Notice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tab_MyDesk_Click(object sender, EventArgs e)
        {

        }

        private void Center_Load(object sender, EventArgs e)
        {
            string Search = $@"SELECT
		                    *
	                        FROM dbo.tb_StudentCard
                            WHERE
		                   No={Studentid};";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            if (sqlHelper.HasRecord)
            {
                this.tb_No.Text = sqlHelper["No"].ToString();
                this.tb_Name.Text = sqlHelper["Name"].ToString();
                this.tb_Academy.Text = sqlHelper["Academy"].ToString();
                this.tb_Major.Text = sqlHelper["Major"].ToString();
                this.tb_Gender.Text = sqlHelper["Gender"].ToString();
                this.tb_BirthDate.Text = ((DateTime)sqlHelper["BirthDate"]).ToShortDateString();
            }
            dgv_LeaveMessage.Visible = false;
            gb_LeaveMessage.Visible = false;
            gb_Notice.Visible = false;
            groupBox2.Visible = false;
            gb_ModifyCode.Visible = false;
            dgv_WarnQuary.Visible = false;
            dgv_Transaction.Visible = false;
            dgv_ScoreInquiry.Visible = false;
            gb_ScoreInquiry.Visible = false;
            gb_SearchCourse.Visible = false;
            gb_GradeMark.Visible = false;
            groupBox4.Visible = false;
            tb_Show.Text = "增加";
            string Search1 = @"SELECT
                                *
                            FROM
	                            tb_TrainProgram	AS TP;";
            SqlHelper sqlHelper1 = new SqlHelper();
            sqlHelper1.QuickRead(Search1);
            while (sqlHelper1.HasRecord)
            {
                int index = this.dgv_TrainProgram.Rows.Add();
                dgv_TrainProgram.Rows[index].Cells[0].Value = sqlHelper1["No"].ToString();
                dgv_TrainProgram.Rows[index].Cells[1].Value = sqlHelper1["Title"].ToString();
                dgv_TrainProgram.Rows[index].Cells[2].Value = sqlHelper1["Operation"].ToString();
            }
        }

        private void Btn_Notice_Click(object sender, EventArgs e)
        {
            dgv_Notice.Rows.Clear();
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
                dgv_Notice.Rows[index1].Cells[5].Value = sqlHelper1["Status"].ToString();
            }
        }

        private void Btn_Leavemessage_Click(object sender, EventArgs e)
        {
            dgv_LeaveMessage.Rows.Clear();
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
                dgv_LeaveMessage.Rows[index4].Cells[4].Value = sqlHelper4["SendTime"].ToString();
                dgv_LeaveMessage.Rows[index4].Cells[5].Value = sqlHelper4["Status"].ToString();
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
		                   No='{this.Studentid}';";
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
                        sqlHelper.QuickSubmit($@"UPDATE dbo.tb_Student SET
                                                      Code='{tb_NewCode.Text.ToString()}'
                                                 WHERE
                                                      dbo.tb_Student.No='3190707045';");
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

        private void dgv_Notice_DoubleClick(object sender, EventArgs e)
        {            
            
        }

        private void dgv_Notice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Detail detail = new Detail();
                detail.Show();
                string comandText =
                    $@"UPDATE tb_Notice
                    SET Status='已读'
                    WHERE StudentNo='{this.Studentid}' AND No={e.RowIndex + 1};";
                SqlHelper sqlHelper = new SqlHelper();
                int rowAffected = sqlHelper.QuickSubmit(comandText);
                if (rowAffected == 1)
                {
                    this.dgv_Notice.Rows[e.RowIndex].Cells[5].Value = "已读";
                }
            }
        }

        private void dgv_LeaveMessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {              
                string comandText =
                    $@"UPDATE tb_LeaveMessage
                    SET Status='已读'
                    WHERE No={e.RowIndex + 1};";
                SqlHelper sqlHelper = new SqlHelper();
                int rowAffected = sqlHelper.QuickSubmit(comandText);
                if (rowAffected == 1)
                {
                    this.dgv_LeaveMessage.Rows[e.RowIndex].Cells[5].Value = "已读";
                }
            }
        }

        private void cb_TermYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_SearchChooseCourse_Click(object sender, EventArgs e)
        {
            dgv_TrainProgram.Visible = false;
            gb_SearchCourse.Visible = true;
        }

        private void LoadCourse()
        {
            string Search = $@"
                                SELECT  PC.* ,
	                                IIF(SS.CourseNo IS NULL,'未选修','已选修') AS Status
                                FROM
	                                dbo.tb_PublicCourse AS PC
	                                LEFT JOIN tb_StudentScore AS SS ON SS.CourseNo=PC.No;";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            while (sqlHelper.HasRecord)
            {
                int index = this.ShowPublicCourse.Rows.Add();
                ShowPublicCourse.Rows[index].Cells[0].Value = sqlHelper["No"].ToString();
                ShowPublicCourse.Rows[index].Cells[1].Value = sqlHelper["Name"].ToString();
                ShowPublicCourse.Rows[index].Cells[2].Value = sqlHelper["Credit"].ToString();
                ShowPublicCourse.Rows[index].Cells[3].Value = sqlHelper["Hour"].ToString();
                ShowPublicCourse.Rows[index].Cells[4].Value = sqlHelper["ExamType"].ToString();
                ShowPublicCourse.Rows[index].Cells[5].Value = sqlHelper["StartTime"].ToString();
                ShowPublicCourse.Rows[index].Cells[6].Value = sqlHelper["Status"].ToString();
            }
            string Search2 = $@"
                                SELECT PC.* ,
	                                IIF(SS.Score IS NULL,'可退选','不可退选') AS Status
                                FROM
	                                dbo.tb_PublicCourse AS PC
	                                JOIN tb_StudentScore AS SS ON SS.CourseNo=PC.No;";
            SqlHelper sqlHelper2 = new SqlHelper();
            sqlHelper2.QuickRead(Search2);
            while (sqlHelper2.HasRecord)
            {
                int index2 = this.dgv_HasChoose.Rows.Add();
                dgv_HasChoose.Rows[index2].Cells[0].Value = sqlHelper2["No"].ToString();
                dgv_HasChoose.Rows[index2].Cells[1].Value = sqlHelper2["Name"].ToString();
                dgv_HasChoose.Rows[index2].Cells[2].Value = sqlHelper2["Credit"].ToString();
                dgv_HasChoose.Rows[index2].Cells[3].Value = sqlHelper2["Hour"].ToString();
                dgv_HasChoose.Rows[index2].Cells[4].Value = sqlHelper2["ExamType"].ToString();
                dgv_HasChoose.Rows[index2].Cells[5].Value = sqlHelper2["StartTime"].ToString();
                dgv_HasChoose.Rows[index2].Cells[6].Value = sqlHelper2["Status"].ToString();
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            if (cb_Type.SelectedItem==null)
            {
                MessageBox.Show("选课类别不能为空!");
            }
            else
            {
                if (cb_TermYear.SelectedItem.ToString() == "2020-2021-1")
                {
                    this.LoadCourse();
                }
                gb_SearchCourse.Visible = false;
            }            
        }

        private void btn_Choose_Click(object sender, EventArgs e)
        {
            string status = this.ShowPublicCourse.CurrentRow.Cells["Status"].ToString();
            if (status == "已选修")
            {
                MessageBox.Show("该课程已选修！");
                return;
            }
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickSubmit($"INSERT tb_StudentScore(CourseNo,StudentNo)VALUES('{this.ShowPublicCourse.CurrentRow.Cells["CourseNo"].Value.ToString()}', '3190707045');");
            ShowPublicCourse.Rows.Clear();
            dgv_HasChoose.Rows.Clear();
            this.LoadCourse();
        }

        private void textBox_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            string status = this.dgv_HasChoose.CurrentRow.Cells["Course_Status"].Value.ToString();
            if (status == "不可退")
            {
                MessageBox.Show("该课已有成绩！不可退选！");
                return;
            }
            SqlHelper sqlHelper = new SqlHelper();
            String Current_course_no = this.dgv_HasChoose.CurrentRow.Cells["course_no"].Value.ToString();
            sqlHelper.QuickSubmit($"DELETE tb_StudentScore WHERE StudentNo='3190707045' AND CourseNo='{Current_course_no}';");
            ShowPublicCourse.Rows.Clear();
            dgv_HasChoose.Rows.Clear();
            this.LoadCourse();
        }
    }
    }
