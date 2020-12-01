using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class TeachingWeek : Form
    {
        public TeachingWeek()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!=null)
            {
                label_Year.Text= this.comboBox1.SelectedItem.ToString().Substring(0, 9).Trim() + "学年";
                lable_Term.Text ="第"+ this.comboBox1.SelectedItem.ToString().Substring(10, 1).Trim() + "学期";
            }
            if (comboBox1.SelectedItem.ToString()=="2019-2020-1")
            {
                pb_2019学年.Visible = true;
                pb_2019学年2.Visible = false;
                pb_2020学年.Visible = false;
                pb_2020学年2.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "2019-2020-2")
            {
                pb_2019学年.Visible = false;
                pb_2019学年2.Visible = true;
                pb_2020学年.Visible = false;
                pb_2020学年2.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "2020-2021-1")
            {
                pb_2019学年.Visible = false;
                pb_2019学年2.Visible = false;
                pb_2020学年.Visible = true;
                pb_2020学年2.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "2020-2021-2")
            {
                pb_2019学年.Visible = false;
                pb_2019学年2.Visible = false;
                pb_2020学年.Visible = false;
                pb_2020学年2.Visible = true;
            }
        }

        private void TeachingWeek_Load(object sender, EventArgs e)
        {

        }
    }
}
