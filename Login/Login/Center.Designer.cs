namespace Login
{
    partial class Center
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Center = new System.Windows.Forms.TabControl();
            this.tab_MyDesk = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Message = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Notice = new System.Windows.Forms.Button();
            this.Btn_Leavemessage = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_TeachingWeek = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_Center.SuspendLayout();
            this.tab_MyDesk.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Message.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Center
            // 
            this.tabControl_Center.Controls.Add(this.tab_MyDesk);
            this.tabControl_Center.Controls.Add(this.tabPage2);
            this.tabControl_Center.Controls.Add(this.tabPage3);
            this.tabControl_Center.Controls.Add(this.tabPage4);
            this.tabControl_Center.Controls.Add(this.tabPage5);
            this.tabControl_Center.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Center.Name = "tabControl_Center";
            this.tabControl_Center.SelectedIndex = 0;
            this.tabControl_Center.Size = new System.Drawing.Size(1054, 616);
            this.tabControl_Center.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Center.TabIndex = 0;
            // 
            // tab_MyDesk
            // 
            this.tab_MyDesk.Controls.Add(this.dataGridView2);
            this.tab_MyDesk.Controls.Add(this.dataGridView1);
            this.tab_MyDesk.Controls.Add(this.groupBox3);
            this.tab_MyDesk.Controls.Add(this.groupBox_Message);
            this.tab_MyDesk.Controls.Add(this.groupBox1);
            this.tab_MyDesk.Location = new System.Drawing.Point(4, 25);
            this.tab_MyDesk.Name = "tab_MyDesk";
            this.tab_MyDesk.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MyDesk.Size = new System.Drawing.Size(1046, 587);
            this.tab_MyDesk.TabIndex = 0;
            this.tab_MyDesk.Text = "我的桌面";
            this.tab_MyDesk.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1046, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "学籍成绩";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(738, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "培养管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(738, 441);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "考试报名";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(918, 463);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "教学评价";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Leavemessage);
            this.groupBox1.Controls.Add(this.Btn_Notice);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公告留言";
            // 
            // groupBox_Message
            // 
            this.groupBox_Message.Controls.Add(this.button2);
            this.groupBox_Message.Controls.Add(this.b);
            this.groupBox_Message.Location = new System.Drawing.Point(3, 142);
            this.groupBox_Message.Name = "groupBox_Message";
            this.groupBox_Message.Size = new System.Drawing.Size(201, 117);
            this.groupBox_Message.TabIndex = 1;
            this.groupBox_Message.TabStop = false;
            this.groupBox_Message.Text = "个人信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_TeachingWeek);
            this.groupBox3.Location = new System.Drawing.Point(6, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 65);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "教学周历";
            // 
            // Btn_Notice
            // 
            this.Btn_Notice.Location = new System.Drawing.Point(30, 36);
            this.Btn_Notice.Name = "Btn_Notice";
            this.Btn_Notice.Size = new System.Drawing.Size(131, 28);
            this.Btn_Notice.TabIndex = 3;
            this.Btn_Notice.Text = "已收公告";
            this.Btn_Notice.UseVisualStyleBackColor = true;
            // 
            // Btn_Leavemessage
            // 
            this.Btn_Leavemessage.Location = new System.Drawing.Point(30, 70);
            this.Btn_Leavemessage.Name = "Btn_Leavemessage";
            this.Btn_Leavemessage.Size = new System.Drawing.Size(131, 28);
            this.Btn_Leavemessage.TabIndex = 4;
            this.Btn_Leavemessage.Text = "已收留言";
            this.Btn_Leavemessage.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(35, 37);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(131, 28);
            this.b.TabIndex = 4;
            this.b.Text = "修改个人信息";
            this.b.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "修改密码";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_TeachingWeek
            // 
            this.btn_TeachingWeek.Location = new System.Drawing.Point(32, 24);
            this.btn_TeachingWeek.Name = "btn_TeachingWeek";
            this.btn_TeachingWeek.Size = new System.Drawing.Size(131, 28);
            this.btn_TeachingWeek.TabIndex = 5;
            this.btn_TeachingWeek.Text = "教学周历查看";
            this.btn_TeachingWeek.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(229, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(741, 156);
            this.dataGridView1.TabIndex = 3;
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "标题";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "类别";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "发送人";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "发送时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(229, 247);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(741, 156);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "标题";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "类别";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "发送人";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "发送时间";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 607);
            this.Controls.Add(this.tabControl_Center);
            this.Name = "Center";
            this.Text = "个人中心";
            this.tabControl_Center.ResumeLayout(false);
            this.tab_MyDesk.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Message.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Center;
        private System.Windows.Forms.TabPage tab_MyDesk;
        private System.Windows.Forms.TabPage tabPage2;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_Message;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button Btn_Leavemessage;
        private System.Windows.Forms.Button Btn_Notice;
        private System.Windows.Forms.Button btn_TeachingWeek;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}