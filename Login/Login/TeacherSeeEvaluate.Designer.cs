namespace Login
{
    partial class TeacherSeeEvaluate
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
            this.CB_Class = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_See = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_See)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级：";
            // 
            // cb_Term
            // 
            this.cb_Term.FormattingEnabled = true;
            this.cb_Term.Items.AddRange(new object[] {
            "---请选择---",
            "2019-2020-1",
            "2019-2020-2"});
            this.cb_Term.Location = new System.Drawing.Point(70, 24);
            this.cb_Term.Name = "cb_Term";
            this.cb_Term.Size = new System.Drawing.Size(145, 23);
            this.cb_Term.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "学期：";
            // 
            // CB_Class
            // 
            this.CB_Class.FormattingEnabled = true;
            this.CB_Class.Items.AddRange(new object[] {
            "---请选择---",
            "19健管",
            "19公管",
            "19信管"});
            this.CB_Class.Location = new System.Drawing.Point(288, 24);
            this.CB_Class.Name = "CB_Class";
            this.CB_Class.Size = new System.Drawing.Size(145, 23);
            this.CB_Class.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(497, 17);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(72, 35);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "查看";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_See
            // 
            this.dgv_See.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_See.Location = new System.Drawing.Point(30, 77);
            this.dgv_See.Name = "dgv_See";
            this.dgv_See.RowTemplate.Height = 27;
            this.dgv_See.Size = new System.Drawing.Size(669, 292);
            this.dgv_See.TabIndex = 5;
            // 
            // TeacherSeeEvaluate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_See);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.CB_Class);
            this.Controls.Add(this.cb_Term);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "TeacherSeeEvaluate";
            this.Text = "查看学生评价";
            this.Load += new System.EventHandler(this.TeacherSeeEvaluate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_See)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Term;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Class;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_See;
    }
}