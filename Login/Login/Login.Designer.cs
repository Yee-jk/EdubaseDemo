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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.textBox_No = new System.Windows.Forms.TextBox();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.btn_See = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(633, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户登录";
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.BackColor = System.Drawing.SystemColors.Control;
            this.No.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.No.Location = new System.Drawing.Point(646, 305);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(69, 20);
            this.No.TabIndex = 1;
            this.No.Text = "账号：";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.BackColor = System.Drawing.SystemColors.Control;
            this.code.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.code.Location = new System.Drawing.Point(646, 374);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(69, 20);
            this.code.TabIndex = 2;
            this.code.Text = "密码：";
            // 
            // textBox_No
            // 
            this.textBox_No.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_No.Location = new System.Drawing.Point(708, 302);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.Size = new System.Drawing.Size(172, 30);
            this.textBox_No.TabIndex = 3;
            this.textBox_No.TextChanged += new System.EventHandler(this.textBox_No_TextChanged);
            // 
            // textBox_Code
            // 
            this.textBox_Code.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Code.Location = new System.Drawing.Point(708, 369);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.PasswordChar = '*';
            this.textBox_Code.Size = new System.Drawing.Size(172, 30);
            this.textBox_Code.TabIndex = 4;
            this.textBox_Code.TextChanged += new System.EventHandler(this.textBox_Code_TextChanged);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.SystemColors.Control;
            this.button_Login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Login.Location = new System.Drawing.Point(782, 438);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 45);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SignIn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SignIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SignIn.Location = new System.Drawing.Point(873, 438);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(75, 45);
            this.btn_SignIn.TabIndex = 6;
            this.btn_SignIn.Text = "注册";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_See
            // 
            this.btn_See.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_See.Location = new System.Drawing.Point(886, 370);
            this.btn_See.Name = "btn_See";
            this.btn_See.Size = new System.Drawing.Size(37, 31);
            this.btn_See.TabIndex = 8;
            this.btn_See.Text = "👁";
            this.btn_See.UseVisualStyleBackColor = true;
            this.btn_See.Click += new System.EventHandler(this.btn_See_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(646, 97);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1074, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_See);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.textBox_No);
            this.Controls.Add(this.code);
            this.Controls.Add(this.No);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "综合教务管理系统";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Button btn_See;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

