namespace Login
{
    partial class BookOrder
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
            this.dgv_Book = new System.Windows.Forms.DataGridView();
            this.gb_Term = new System.Windows.Forms.GroupBox();
            this.cb_Term = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IFUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IFSubscribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).BeginInit();
            this.gb_Term.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Book
            // 
            this.dgv_Book.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.ISBN,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.IFUse,
            this.IFSubscribe});
            this.dgv_Book.Location = new System.Drawing.Point(12, 12);
            this.dgv_Book.Name = "dgv_Book";
            this.dgv_Book.RowTemplate.Height = 27;
            this.dgv_Book.Size = new System.Drawing.Size(1294, 512);
            this.dgv_Book.TabIndex = 0;
            this.dgv_Book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Book_CellClick);
            this.dgv_Book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Book_CellContentClick);
            // 
            // gb_Term
            // 
            this.gb_Term.BackColor = System.Drawing.SystemColors.Control;
            this.gb_Term.Controls.Add(this.btn_Search);
            this.gb_Term.Controls.Add(this.cb_Term);
            this.gb_Term.Controls.Add(this.label1);
            this.gb_Term.Location = new System.Drawing.Point(375, 12);
            this.gb_Term.Name = "gb_Term";
            this.gb_Term.Size = new System.Drawing.Size(410, 148);
            this.gb_Term.TabIndex = 1;
            this.gb_Term.TabStop = false;
            // 
            // cb_Term
            // 
            this.cb_Term.FormattingEnabled = true;
            this.cb_Term.Items.AddRange(new object[] {
            "2020-2021-1",
            "2020-2021-2"});
            this.cb_Term.Location = new System.Drawing.Point(132, 40);
            this.cb_Term.Name = "cb_Term";
            this.cb_Term.Size = new System.Drawing.Size(182, 23);
            this.cb_Term.TabIndex = 0;
            this.cb_Term.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "学年：";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(176, 88);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(73, 36);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "学年学期";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "课程号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "课程名称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN书号";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "教材名称";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "作者";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "出版社";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "金额";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // IFUse
            // 
            this.IFUse.HeaderText = "是否选用";
            this.IFUse.Name = "IFUse";
            this.IFUse.ReadOnly = true;
            // 
            // IFSubscribe
            // 
            this.IFSubscribe.HeaderText = "操作";
            this.IFSubscribe.Name = "IFSubscribe";
            this.IFSubscribe.ReadOnly = true;
            // 
            // BookOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 667);
            this.Controls.Add(this.gb_Term);
            this.Controls.Add(this.dgv_Book);
            this.Name = "BookOrder";
            this.Text = "教材征订";
            this.Load += new System.EventHandler(this.BookOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).EndInit();
            this.gb_Term.ResumeLayout(false);
            this.gb_Term.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Book;
        private System.Windows.Forms.GroupBox gb_Term;
        private System.Windows.Forms.ComboBox cb_Term;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IFUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn IFSubscribe;
    }
}