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
            this.btn_Center.Focus();
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
                this.textBox_Gender.Text = sqlHelper["Gender"].ToString();
                this.textBox_BirhDate.Text = ((DateTime)sqlHelper["BirthDate"]).ToShortDateString();
            }
        }

        private void textBox_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Notice_Click(object sender, EventArgs e)
        {
            Notice notice = new Notice();
            notice.Show();    
        }

        private void btn_leavemessage_Click(object sender, EventArgs e)
        {
            LeaveMessage leaveMessage = new LeaveMessage();
            leaveMessage.Show();
        }

        private void btn_Center_Click(object sender, EventArgs e)
        {
            Center center = new Center();
            center.Show();
            
        }
    }
}
