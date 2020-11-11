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
            this.FormClosed += (_, __) =>
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
            };
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            string Search1= @"SELECT
                            *
                           FROM
                            dbo.tb_Notice AS N
                           WHERE
                              N.No='1'; ";
            SqlHelper sqlHelper1 = new SqlHelper();
            sqlHelper1.QuickRead(Search1);
            if (sqlHelper1.HasRecord)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sqlHelper1["No"].ToString();
                listViewItem.SubItems.Add(sqlHelper1["Title"].ToString());
                listViewItem.SubItems.Add(sqlHelper1["Type"].ToString());
                listViewItem.SubItems.Add(sqlHelper1["Sender"].ToString());
                listViewItem.SubItems.Add(sqlHelper1["SendTime"].ToString());
                listView1.Items.Add(listViewItem);
            }
            string Search2 = @"SELECT
                            *
                           FROM
                            dbo.tb_Notice AS N
                           WHERE
                              N.No='2'; ";
            SqlHelper sqlHelper2 = new SqlHelper();
            sqlHelper2.QuickRead(Search2);
            if (sqlHelper2.HasRecord)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sqlHelper2["No"].ToString();
                listViewItem.SubItems.Add(sqlHelper2["Title"].ToString());
                listViewItem.SubItems.Add(sqlHelper2["Type"].ToString());
                listViewItem.SubItems.Add(sqlHelper2["Sender"].ToString());
                listViewItem.SubItems.Add(sqlHelper2["SendTime"].ToString());
                listView1.Items.Add(listViewItem);
            }
            string Search3 = @"SELECT
                            *
                           FROM
                            dbo.tb_Notice AS N
                           WHERE
                              N.No='3'; ";
            SqlHelper sqlHelper3 = new SqlHelper();
            sqlHelper3.QuickRead(Search3);
            if (sqlHelper3.HasRecord)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sqlHelper3["No"].ToString();
                listViewItem.SubItems.Add(sqlHelper3["Title"].ToString());
                listViewItem.SubItems.Add(sqlHelper3["Type"].ToString());
                listViewItem.SubItems.Add(sqlHelper3["Sender"].ToString());
                listViewItem.SubItems.Add(sqlHelper3["SendTime"].ToString());
                listView1.Items.Add(listViewItem);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Enter BackEnter = new Enter();
            BackEnter.Show();
            this.Close();
        }
    }
}
