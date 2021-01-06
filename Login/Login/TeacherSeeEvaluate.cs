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
    public partial class TeacherSeeEvaluate : Form
    {
        string TeacherNo;
        public TeacherSeeEvaluate()
        {
            InitializeComponent();
        }
        public TeacherSeeEvaluate(String teacherNo) : this()
        {
            TeacherNo = teacherNo;
        }

        private void TeacherSeeEvaluate_Load(object sender, EventArgs e)
        {
            cb_Term.SelectedItem = "---请选择---";
            CB_Class.SelectedItem = "---请选择---";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            if (cb_Term.SelectedItem.ToString()!= "---请选择---")
            {
                if (CB_Class.SelectedItem.ToString()!= "---请选择---")
                {
                    string Search = $@"SELECT
	                                     CG.Term AS 学期
                                         ,S.No AS 教师工号
	                                     ,CG.CourseNo AS 课程号
	                                     ,CG.CourseName AS 课程名称
	                                     ,TE .Score AS 评分
	                                     ,TE.Evaluate AS 评语
                                         ,S.ClassShort AS 班级
	                                FROM tb_CourseGrade AS CG 
	                                LEFT JOIN tb_TeacherEvaluate AS TE ON TE.CourseNo=CG.CourseNo
	                                LEFT JOIN tb_Student AS S ON S.No=TE.TeacherNo
                                    WHERE CG.Term={cb_Term.SelectedItem.ToString()} AND S.ClassShort={CB_Class.SelectedItem.ToString()} AND S.No={TeacherNo};";
                    sqlHelper.QuickFill(Search, this.dgv_See);
                }
                else
                {
                    string Search = $@"SELECT
	                                     CG.Term AS 学期
                                         ,S.No AS 教师工号
	                                     ,CG.CourseNo AS 课程号
	                                     ,CG.CourseName AS 课程名称
	                                     ,TE .Score AS 评分
	                                     ,TE.Evaluate AS 评语
                                         ,S.ClassShort AS 班级
	                                FROM tb_CourseGrade AS CG 
	                                LEFT JOIN tb_TeacherEvaluate AS TE ON TE.CourseNo=CG.CourseNo
	                                LEFT JOIN tb_Student AS S ON S.No=TE.TeacherNo
                                    WHERE CG.Term={cb_Term.SelectedItem.ToString()} AND S.No={TeacherNo};";
                    sqlHelper.QuickFill(Search, this.dgv_See);
                }
            }
        }
    }
}
