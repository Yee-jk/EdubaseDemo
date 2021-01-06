namespace Login
{
    partial class StudentAchievement
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
            this.gb_ScoreInquiry = new System.Windows.Forms.GroupBox();
            this.tb_CourseName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.cb_CourseNature = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_StartTime = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dgv_ScoreInquiry = new System.Windows.Forms.DataGridView();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_ScoreInquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScoreInquiry)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ScoreInquiry
            // 
            this.gb_ScoreInquiry.Controls.Add(this.tb_CourseName);
            this.gb_ScoreInquiry.Controls.Add(this.btn_Search);
            this.gb_ScoreInquiry.Controls.Add(this.label25);
            this.gb_ScoreInquiry.Controls.Add(this.cb_CourseNature);
            this.gb_ScoreInquiry.Controls.Add(this.label24);
            this.gb_ScoreInquiry.Controls.Add(this.cb_StartTime);
            this.gb_ScoreInquiry.Controls.Add(this.label23);
            this.gb_ScoreInquiry.Location = new System.Drawing.Point(12, 12);
            this.gb_ScoreInquiry.Name = "gb_ScoreInquiry";
            this.gb_ScoreInquiry.Size = new System.Drawing.Size(581, 164);
            this.gb_ScoreInquiry.TabIndex = 18;
            this.gb_ScoreInquiry.TabStop = false;
            // 
            // tb_CourseName
            // 
            this.tb_CourseName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_CourseName.Location = new System.Drawing.Point(148, 112);
            this.tb_CourseName.Name = "tb_CourseName";
            this.tb_CourseName.Size = new System.Drawing.Size(211, 28);
            this.tb_CourseName.TabIndex = 9;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(420, 98);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(72, 42);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label25
            // 
            this.label25.AllowDrop = true;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(64, 117);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 15);
            this.label25.TabIndex = 6;
            this.label25.Text = "课程名称：";
            // 
            // cb_CourseNature
            // 
            this.cb_CourseNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CourseNature.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_CourseNature.FormattingEnabled = true;
            this.cb_CourseNature.Items.AddRange(new object[] {
            "---请选择---",
            "公共基础课",
            "专业基础课",
            "专业课",
            "专业选修课",
            "公共选修课",
            "通识教育课",
            "学科基础课",
            "专业教育课"});
            this.cb_CourseNature.Location = new System.Drawing.Point(148, 68);
            this.cb_CourseNature.Name = "cb_CourseNature";
            this.cb_CourseNature.Size = new System.Drawing.Size(211, 26);
            this.cb_CourseNature.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(64, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 15);
            this.label24.TabIndex = 2;
            this.label24.Text = "课程性质：";
            // 
            // cb_StartTime
            // 
            this.cb_StartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_StartTime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_StartTime.FormattingEnabled = true;
            this.cb_StartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_StartTime.Items.AddRange(new object[] {
            "---请选择---",
            "2019-2020-1",
            "2019-2020-2",
            "2020-2021-1",
            "2020-2021-2"});
            this.cb_StartTime.Location = new System.Drawing.Point(148, 29);
            this.cb_StartTime.Name = "cb_StartTime";
            this.cb_StartTime.Size = new System.Drawing.Size(211, 26);
            this.cb_StartTime.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(64, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 15);
            this.label23.TabIndex = 0;
            this.label23.Text = "开课时间：";
            // 
            // dgv_ScoreInquiry
            // 
            this.dgv_ScoreInquiry.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ScoreInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ScoreInquiry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column28,
            this.Column29,
            this.Column30,
            this.Column31,
            this.Column32,
            this.Column33,
            this.Column34,
            this.Column35,
            this.Column36});
            this.dgv_ScoreInquiry.Location = new System.Drawing.Point(30, 182);
            this.dgv_ScoreInquiry.Name = "dgv_ScoreInquiry";
            this.dgv_ScoreInquiry.RowTemplate.Height = 27;
            this.dgv_ScoreInquiry.Size = new System.Drawing.Size(1130, 342);
            this.dgv_ScoreInquiry.TabIndex = 19;
            // 
            // Column28
            // 
            this.Column28.HeaderText = "开课学期";
            this.Column28.Name = "Column28";
            // 
            // Column29
            // 
            this.Column29.HeaderText = "课程编号";
            this.Column29.Name = "Column29";
            // 
            // Column30
            // 
            this.Column30.HeaderText = "课程名称";
            this.Column30.Name = "Column30";
            // 
            // Column31
            // 
            this.Column31.HeaderText = "成绩";
            this.Column31.Name = "Column31";
            // 
            // Column32
            // 
            this.Column32.HeaderText = "学分";
            this.Column32.Name = "Column32";
            // 
            // Column33
            // 
            this.Column33.HeaderText = "总学时";
            this.Column33.Name = "Column33";
            // 
            // Column34
            // 
            this.Column34.HeaderText = "考核方式";
            this.Column34.Name = "Column34";
            // 
            // Column35
            // 
            this.Column35.HeaderText = "课程属性";
            this.Column35.Name = "Column35";
            // 
            // Column36
            // 
            this.Column36.HeaderText = "课程性质";
            this.Column36.Name = "Column36";
            // 
            // StudentAchievement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 587);
            this.Controls.Add(this.gb_ScoreInquiry);
            this.Controls.Add(this.dgv_ScoreInquiry);
            this.Name = "StudentAchievement";
            this.Text = "课程成绩查询";
            this.Load += new System.EventHandler(this.StudentAchievement_Load);
            this.gb_ScoreInquiry.ResumeLayout(false);
            this.gb_ScoreInquiry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScoreInquiry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ScoreInquiry;
        private System.Windows.Forms.TextBox tb_CourseName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cb_CourseNature;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cb_StartTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgv_ScoreInquiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column33;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column34;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column35;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
    }
}