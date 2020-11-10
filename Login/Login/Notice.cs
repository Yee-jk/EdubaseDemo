using System;
using System.Windows.Forms;
using SmartLinli.DatabaseDevelopement;

namespace Login
{
    public partial class Notice : Form
    {
        public Notice()
        {
            InitializeComponent();
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            string Search= @"SELECT
                            *
                           FROM
                            dbo.tb_Notice AS N
                           WHERE
                              N.No='1'; ";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(Search);
            if (sqlHelper.HasRecord)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sqlHelper["No"].ToString();
                listViewItem.SubItems.Add(sqlHelper["Title"].ToString());
                listViewItem.SubItems.Add(sqlHelper["Type"].ToString());
                listViewItem.SubItems.Add(sqlHelper["Sender"].ToString());
                listViewItem.SubItems.Add(sqlHelper["SendTime"].ToString());
                listView1.Items.Add(listViewItem);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
