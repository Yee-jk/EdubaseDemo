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
    public partial class StudentAchievement : Form
    {
        private string Studentid;
        public StudentAchievement()
        {
            InitializeComponent();
        }
        public StudentAchievement(String StudentNo) : this()
        {
            Studentid = StudentNo;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            string evaluatedCommand = $@"SELECT
                                        	COUNT(1) AS COUNT
                                       	From tb_TeacherEvaluate AS TE
                                            WHERE  TE.StudentNo='{Studentid}' AND TE.Score is null;";
            sqlHelper.QuickRead(evaluatedCommand);
            if (sqlHelper.HasRecord)
            {
                if (sqlHelper["COUNT"].ToString() != "0")
                {
                    MessageBox.Show("全部评教完成后才能查看成绩，请先评教！");           
                }
                else
                {
                    dgv_ScoreInquiry.Visible = true;                   
                    dgv_ScoreInquiry.Rows.Clear();
                    if (tb_CourseName.Text != "")
                    {
                        String Search = $@"SELECT *
                                   FROM dbo.tb_CourseGrade	  AS CG
                                  WHERE CG.CourseName='{tb_CourseName.Text}';";
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
                        return;
                    }
                    if (cb_StartTime.SelectedItem.ToString() == "---请选择---" && cb_CourseNature.SelectedItem.ToString() != "---请选择---")
                    {
                        String Search = $@"SELECT *
                                   FROM dbo.tb_CourseGrade	  AS CG
                                  WHERE CG.CourseNature='{cb_CourseNature.SelectedItem}';";                       
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
                    if (cb_StartTime.SelectedItem.ToString() == "---请选择---" && cb_CourseNature.SelectedItem.ToString() == "---请选择---")
                    {
                        String Search = $@"SELECT
                                *
                            FROM
	                            dbo.tb_CourseGrade;";                        
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
                    if (cb_StartTime.SelectedItem.ToString() != "---请选择---" && cb_CourseNature.SelectedItem.ToString() == "---请选择---")
                    {
                        String Search = $@"SELECT *
                                   FROM dbo.tb_CourseGrade	  AS CG
                                  WHERE CG.Term='{cb_StartTime.SelectedItem}';";                       
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
                    if (cb_StartTime.SelectedItem.ToString() != "---请选择---" && cb_CourseNature.SelectedItem.ToString() != "---请选择---")
                    {
                        String Search = $@"SELECT *
                                   FROM dbo.tb_CourseGrade	  AS CG
                                  WHERE CG.Term='{cb_StartTime.SelectedItem}'
                                  AND CG.CourseNature='{cb_CourseNature.SelectedItem}';";                      
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

                }
            }
            
        }

        private void StudentAchievement_Load(object sender, EventArgs e)
        {
            cb_StartTime.SelectedItem = "---请选择---";
            cb_CourseNature.SelectedItem = "---请选择---";
            dgv_ScoreInquiry.Visible = false;
            gb_ScoreInquiry.Visible = true;
        }
    }
    }


