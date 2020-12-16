namespace Login
{
    partial class Detail
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
            this.tb_Detail = new System.Windows.Forms.TextBox();
            this.tb_Reply = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_ShowReply = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Detail
            // 
            this.tb_Detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Detail.Location = new System.Drawing.Point(62, 12);
            this.tb_Detail.Multiline = true;
            this.tb_Detail.Name = "tb_Detail";
            this.tb_Detail.ReadOnly = true;
            this.tb_Detail.Size = new System.Drawing.Size(419, 134);
            this.tb_Detail.TabIndex = 0;
            this.tb_Detail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_Reply
            // 
            this.tb_Reply.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Reply.Location = new System.Drawing.Point(242, 263);
            this.tb_Reply.Name = "tb_Reply";
            this.tb_Reply.Size = new System.Drawing.Size(189, 30);
            this.tb_Reply.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "回复";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_ShowReply
            // 
            this.tb_ShowReply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ShowReply.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_ShowReply.Location = new System.Drawing.Point(411, 136);
            this.tb_ShowReply.Name = "tb_ShowReply";
            this.tb_ShowReply.ReadOnly = true;
            this.tb_ShowReply.Size = new System.Drawing.Size(70, 23);
            this.tb_ShowReply.TabIndex = 3;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 324);
            this.Controls.Add(this.tb_ShowReply);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Reply);
            this.Controls.Add(this.tb_Detail);
            this.Name = "Detail";
            this.Text = "详情";
            this.Load += new System.EventHandler(this.Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Detail;
        private System.Windows.Forms.TextBox tb_Reply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_ShowReply;
    }
}