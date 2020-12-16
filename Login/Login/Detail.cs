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
    public partial class Detail : Form
    {
        string DetailText;
        string CurrentIndex;
        string NTReplyDetail;
        public Detail()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public Detail(string text,string reply,string index) : this()
        {
            this.DetailText = text;
            this.tb_ShowReply.Text = reply;
            this.CurrentIndex = index;
        }
        private void Detail_Load(object sender, EventArgs e)
        {
            tb_Detail.Text = DetailText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_ShowReply.Text = tb_Reply.Text;           
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickSubmit($"UPDATE tb_Status  SET NTReplyDetail = '{tb_Reply.Text}' WHERE NoticeNo = '{CurrentIndex}';");
            tb_Reply.Text = "";
        }
    }
}
