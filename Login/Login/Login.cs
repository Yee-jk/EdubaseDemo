using SmartLinli.DatabaseDevelopement;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void button_Login_Click(object sender, EventArgs e)
        {
            string Search = $@"SELECT
		                        1
	                          FROM dbo.tb_Student
	                            WHERE
		                       No={this.textBox_No.Text} AND Code={this.textBox_Code.Text};";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(Search);
            if (result == 1)
            {
                Enter enter = new Enter(this.textBox_No.Text);
                enter.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");
                this.textBox_Code.Focus();
                this.textBox_Code.SelectAll();
            }
        }

        private void textBox_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"INSERT tb_Student(No,Code)
					VALUES
					('{this.textBox_No.Text.Trim()}','{this.textBox_Code.Text.Trim()}');";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper.QuickSubmit(commandText);
            if (rowAffected == 1)
            {
                MessageBox.Show("注册成功。");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
    }
}
