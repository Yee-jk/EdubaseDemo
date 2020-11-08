namespace Login
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.textBox_No = new System.Windows.Forms.TextBox();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(192, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户登录";
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.No.Location = new System.Drawing.Point(155, 129);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(69, 20);
            this.No.TabIndex = 1;
            this.No.Text = "账号：";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.code.Location = new System.Drawing.Point(155, 196);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(69, 20);
            this.code.TabIndex = 2;
            this.code.Text = "密码：";
            // 
            // textBox_No
            // 
            this.textBox_No.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_No.Location = new System.Drawing.Point(230, 119);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.Size = new System.Drawing.Size(172, 30);
            this.textBox_No.TabIndex = 3;
            // 
            // textBox_Code
            // 
            this.textBox_Code.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Code.Location = new System.Drawing.Point(230, 196);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(172, 30);
            this.textBox_Code.TabIndex = 4;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Login.Location = new System.Drawing.Point(374, 272);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 45);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 376);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.textBox_No);
            this.Controls.Add(this.code);
            this.Controls.Add(this.No);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "综合教务管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label No;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.TextBox textBox_No;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Button button_Login;
    }
}

