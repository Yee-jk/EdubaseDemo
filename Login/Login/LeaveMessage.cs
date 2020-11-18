using System;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace Login
{
    public partial class LeaveMessage : Form
    {
        public LeaveMessage()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LeaveMessage_Load(object sender, EventArgs e)
        {
            string Search1 = @"SELECT
                            *
                           FROM
                            dbo.tb_LeaveMessage AS L
                           WHERE
                              L.No='1'; ";
            SqlHelper sqlHelper1 = new SqlHelper();
            sqlHelper1.QuickRead(Search1);
            if (sqlHelper1.HasRecord)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sqlHelper1["No"].ToString();
                listViewItem.SubItems.Add(sqlHelper1["Title"].ToString());
                listViewItem.SubItems.Add(sqlHelper1["Type"].ToString());
                listViewItem.SubItems.Add(sqlHelper1["Sender"].ToString());
                listViewItem.SubItems.Add(sqlHelper1["Sendtime"].ToString());
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
