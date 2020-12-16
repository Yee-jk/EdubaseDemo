namespace Login
{
    partial class ClassBorrow
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Term = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Building = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ClassRoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_WeekStart = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_DayStart = new System.Windows.Forms.ComboBox();
            this.cb_SectionStart = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_WeekEnd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_DayEnd = new System.Windows.Forms.ComboBox();
            this.cb_SectionEnd = new System.Windows.Forms.ComboBox();
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.dgv_ClassBorrow = new System.Windows.Forms.DataGridView();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClassBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学期：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_Term
            // 
            this.cb_Term.FormattingEnabled = true;
            this.cb_Term.Items.AddRange(new object[] {
            "2020-2021-1",
            "2020-2021-2"});
            this.cb_Term.Location = new System.Drawing.Point(87, 24);
            this.cb_Term.Name = "cb_Term";
            this.cb_Term.Size = new System.Drawing.Size(143, 23);
            this.cb_Term.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "教学楼：";
            // 
            // cb_Building
            // 
            this.cb_Building.FormattingEnabled = true;
            this.cb_Building.Items.AddRange(new object[] {
            "---请选择---",
            "自强楼",
            "厚德楼",
            "五行楼",
            "精诚楼"});
            this.cb_Building.Location = new System.Drawing.Point(321, 23);
            this.cb_Building.Name = "cb_Building";
            this.cb_Building.Size = new System.Drawing.Size(143, 23);
            this.cb_Building.TabIndex = 3;
            this.cb_Building.SelectedIndexChanged += new System.EventHandler(this.cb_Building_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "教室：";
            // 
            // cb_ClassRoom
            // 
            this.cb_ClassRoom.FormattingEnabled = true;
            this.cb_ClassRoom.Location = new System.Drawing.Point(547, 23);
            this.cb_ClassRoom.Name = "cb_ClassRoom";
            this.cb_ClassRoom.Size = new System.Drawing.Size(143, 23);
            this.cb_ClassRoom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "借用院系：";
            // 
            // cb_Department
            // 
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Items.AddRange(new object[] {
            "---请选择---",
            "研究生院",
            "中西医结合学院",
            "人文与管理学院",
            "护理学院"});
            this.cb_Department.Location = new System.Drawing.Point(87, 74);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(143, 23);
            this.cb_Department.TabIndex = 7;
            this.cb_Department.SelectedIndexChanged += new System.EventHandler(this.cb_Department_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "周次：";
            // 
            // cb_WeekStart
            // 
            this.cb_WeekStart.FormattingEnabled = true;
            this.cb_WeekStart.Items.AddRange(new object[] {
            "请选择",
            "第一周",
            "第二周",
            "第三周",
            "第四周",
            "第五周",
            "第六周"});
            this.cb_WeekStart.Location = new System.Drawing.Point(321, 74);
            this.cb_WeekStart.Name = "cb_WeekStart";
            this.cb_WeekStart.Size = new System.Drawing.Size(58, 23);
            this.cb_WeekStart.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "星期：";
            // 
            // cb_DayStart
            // 
            this.cb_DayStart.FormattingEnabled = true;
            this.cb_DayStart.Items.AddRange(new object[] {
            "请选择",
            "周一",
            "周二",
            "周三",
            "周四",
            "周五"});
            this.cb_DayStart.Location = new System.Drawing.Point(547, 74);
            this.cb_DayStart.Name = "cb_DayStart";
            this.cb_DayStart.Size = new System.Drawing.Size(56, 23);
            this.cb_DayStart.TabIndex = 11;
            // 
            // cb_SectionStart
            // 
            this.cb_SectionStart.FormattingEnabled = true;
            this.cb_SectionStart.Items.AddRange(new object[] {
            "请选择",
            "第一节",
            "第二节",
            "第三节",
            "第四节",
            "第五节",
            "第六节",
            "第七节",
            "第八节"});
            this.cb_SectionStart.Location = new System.Drawing.Point(770, 74);
            this.cb_SectionStart.Name = "cb_SectionStart";
            this.cb_SectionStart.Size = new System.Drawing.Size(49, 23);
            this.cb_SectionStart.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(724, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "节次：";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(950, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 39);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "至";
            // 
            // cb_WeekEnd
            // 
            this.cb_WeekEnd.FormattingEnabled = true;
            this.cb_WeekEnd.Items.AddRange(new object[] {
            "请选择",
            "第一周",
            "第二周",
            "第三周",
            "第四周",
            "第五周",
            "第六周"});
            this.cb_WeekEnd.Location = new System.Drawing.Point(413, 74);
            this.cb_WeekEnd.Name = "cb_WeekEnd";
            this.cb_WeekEnd.Size = new System.Drawing.Size(58, 23);
            this.cb_WeekEnd.TabIndex = 16;
            this.cb_WeekEnd.SelectedIndexChanged += new System.EventHandler(this.cb_WeekEnd_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "至";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(825, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "至";
            // 
            // cb_DayEnd
            // 
            this.cb_DayEnd.FormattingEnabled = true;
            this.cb_DayEnd.Items.AddRange(new object[] {
            "请选择",
            "周一",
            "周二",
            "周三",
            "周四",
            "周五"});
            this.cb_DayEnd.Location = new System.Drawing.Point(646, 74);
            this.cb_DayEnd.Name = "cb_DayEnd";
            this.cb_DayEnd.Size = new System.Drawing.Size(56, 23);
            this.cb_DayEnd.TabIndex = 21;
            this.cb_DayEnd.SelectedIndexChanged += new System.EventHandler(this.cb_DayEnd_SelectedIndexChanged);
            // 
            // cb_SectionEnd
            // 
            this.cb_SectionEnd.FormattingEnabled = true;
            this.cb_SectionEnd.Items.AddRange(new object[] {
            "请选择",
            "第一节",
            "第二节",
            "第三节",
            "第四节",
            "第五节",
            "第六节",
            "第七节",
            "第八节"});
            this.cb_SectionEnd.Location = new System.Drawing.Point(853, 74);
            this.cb_SectionEnd.Name = "cb_SectionEnd";
            this.cb_SectionEnd.Size = new System.Drawing.Size(49, 23);
            this.cb_SectionEnd.TabIndex = 22;
            this.cb_SectionEnd.SelectedIndexChanged += new System.EventHandler(this.cb_SectionEnd_SelectedIndexChanged);
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.Location = new System.Drawing.Point(950, 65);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(75, 39);
            this.btn_Borrow.TabIndex = 23;
            this.btn_Borrow.Text = "借用";
            this.btn_Borrow.UseVisualStyleBackColor = true;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // dgv_ClassBorrow
            // 
            this.dgv_ClassBorrow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ClassBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ClassBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Term,
            this.Building,
            this.ClassRoom,
            this.Department,
            this.Week,
            this.Day,
            this.Section});
            this.dgv_ClassBorrow.Location = new System.Drawing.Point(12, 130);
            this.dgv_ClassBorrow.Name = "dgv_ClassBorrow";
            this.dgv_ClassBorrow.RowTemplate.Height = 27;
            this.dgv_ClassBorrow.Size = new System.Drawing.Size(1215, 486);
            this.dgv_ClassBorrow.TabIndex = 24;
            // 
            // Term
            // 
            this.Term.HeaderText = "学期";
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            // 
            // Building
            // 
            this.Building.HeaderText = "教学楼";
            this.Building.Name = "Building";
            this.Building.ReadOnly = true;
            // 
            // ClassRoom
            // 
            this.ClassRoom.HeaderText = "教室";
            this.ClassRoom.Name = "ClassRoom";
            this.ClassRoom.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "借用院系";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 150;
            // 
            // Week
            // 
            this.Week.HeaderText = "周次";
            this.Week.Name = "Week";
            this.Week.ReadOnly = true;
            this.Week.Width = 150;
            // 
            // Day
            // 
            this.Day.HeaderText = "星期";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 150;
            // 
            // Section
            // 
            this.Section.HeaderText = "节次";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Width = 150;
            // 
            // ClassBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 628);
            this.Controls.Add(this.dgv_ClassBorrow);
            this.Controls.Add(this.btn_Borrow);
            this.Controls.Add(this.cb_SectionEnd);
            this.Controls.Add(this.cb_DayEnd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_WeekEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cb_SectionStart);
            this.Controls.Add(this.cb_DayStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_WeekStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_ClassRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Building);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Term);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "ClassBorrow";
            this.Text = "教室借用";
            this.Load += new System.EventHandler(this.ClassBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClassBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Term;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Building;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ClassRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_WeekStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_DayStart;
        private System.Windows.Forms.ComboBox cb_SectionStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_WeekEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_DayEnd;
        private System.Windows.Forms.ComboBox cb_SectionEnd;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.DataGridView dgv_ClassBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
    }
}