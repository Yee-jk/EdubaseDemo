using System;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace Login
{

    public partial class Enter : Form
    {
        private string _StudentNo;
        public Enter()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosed += (_, __) =>
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
            };
        }
        public Enter(string studentNo) : this()
        {
            _StudentNo = studentNo;
        }

        private void Enter_Load(object sender, EventArgs e)
        {
            string Search = $@"SELECT
		                    *
	                        FROM dbo.tb_StudentCard
                            WHERE
		                   No={_StudentNo};";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            if (sqlHelper.HasRecord)
            {
                this.textBox_no.Text = sqlHelper["No"].ToString();
                this.textBox_Name.Text = sqlHelper["Name"].ToString();
                this.textBox_Academy.Text = sqlHelper["Academy"].ToString();
                this.textBox_Major.Text = sqlHelper["Major"].ToString();
                if (sqlHelper["Gender"].ToString()=="1")
                {
                    this.textBox_Gender.Text ="女";
                }
                else
                {
                    this.textBox_Gender.Text = "男";
                }
                this.textBox_BirhDate.Text = ((DateTime)sqlHelper["BirthDate"]).ToShortDateString();
            }
        }
    }
}
