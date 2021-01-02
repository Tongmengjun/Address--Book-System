
namespace 通讯录信息管路系统
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btt_Login = new System.Windows.Forms.Button();
            this.lb_Regist = new System.Windows.Forms.Button();
            this.lb_Logout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Account_Password = new System.Windows.Forms.TextBox();
            this.tB_Account_Username = new System.Windows.Forms.TextBox();
            this.pctrB_Image = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Image)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btt_Login
            // 
            this.btt_Login.AutoSize = true;
            this.btt_Login.BackColor = System.Drawing.Color.Transparent;
            this.btt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_Login.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btt_Login.Location = new System.Drawing.Point(407, 320);
            this.btt_Login.Name = "btt_Login";
            this.btt_Login.Size = new System.Drawing.Size(92, 45);
            this.btt_Login.TabIndex = 3;
            this.btt_Login.Text = "登 录";
            this.btt_Login.UseVisualStyleBackColor = false;
            this.btt_Login.Click += new System.EventHandler(this.btt_Login_Click);
            // 
            // lb_Regist
            // 
            this.lb_Regist.AutoSize = true;
            this.lb_Regist.BackColor = System.Drawing.Color.Transparent;
            this.lb_Regist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Regist.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Regist.Location = new System.Drawing.Point(523, 320);
            this.lb_Regist.Name = "lb_Regist";
            this.lb_Regist.Size = new System.Drawing.Size(132, 45);
            this.lb_Regist.TabIndex = 4;
            this.lb_Regist.Text = "注册账户";
            this.lb_Regist.UseVisualStyleBackColor = false;
            this.lb_Regist.Click += new System.EventHandler(this.lb_Regist_Click);
            // 
            // lb_Logout
            // 
            this.lb_Logout.AutoSize = true;
            this.lb_Logout.BackColor = System.Drawing.Color.Transparent;
            this.lb_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Logout.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Logout.Location = new System.Drawing.Point(437, 376);
            this.lb_Logout.Name = "lb_Logout";
            this.lb_Logout.Size = new System.Drawing.Size(162, 50);
            this.lb_Logout.TabIndex = 5;
            this.lb_Logout.Text = "注销账户";
            this.lb_Logout.UseVisualStyleBackColor = false;
            this.lb_Logout.Click += new System.EventHandler(this.lb_Logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(355, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "账号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(356, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "密码:";
            // 
            // tB_Account_Password
            // 
            this.tB_Account_Password.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_Account_Password.Location = new System.Drawing.Point(424, 271);
            this.tB_Account_Password.Name = "tB_Account_Password";
            this.tB_Account_Password.PasswordChar = '*';
            this.tB_Account_Password.Size = new System.Drawing.Size(215, 30);
            this.tB_Account_Password.TabIndex = 2;
            this.tB_Account_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tB_Account_Password_MouseClick);
            // 
            // tB_Account_Username
            // 
            this.tB_Account_Username.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_Account_Username.Location = new System.Drawing.Point(423, 208);
            this.tB_Account_Username.Name = "tB_Account_Username";
            this.tB_Account_Username.Size = new System.Drawing.Size(215, 30);
            this.tB_Account_Username.TabIndex = 1;
            this.tB_Account_Username.Text = "1924295926";
            // 
            // pctrB_Image
            // 
            this.pctrB_Image.Image = ((System.Drawing.Image)(resources.GetObject("pctrB_Image.Image")));
            this.pctrB_Image.Location = new System.Drawing.Point(456, 43);
            this.pctrB_Image.Name = "pctrB_Image";
            this.pctrB_Image.Size = new System.Drawing.Size(133, 135);
            this.pctrB_Image.TabIndex = 9;
            this.pctrB_Image.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("楷体", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(187, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 60);
            this.label5.TabIndex = 10;
            this.label5.Text = "登录";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 46);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(670, 40);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "欢迎使用";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(20, 40);
            this.toolStripStatusLabel3.Text = " ";
            // 
            // Login
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 499);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pctrB_Image);
            this.Controls.Add(this.tB_Account_Username);
            this.Controls.Add(this.tB_Account_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Logout);
            this.Controls.Add(this.lb_Regist);
            this.Controls.Add(this.btt_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Image)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button btt_Login;
        private System.Windows.Forms.Button lb_Regist;
        private System.Windows.Forms.Button lb_Logout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_Account_Password;
        private System.Windows.Forms.TextBox tB_Account_Username;
        private System.Windows.Forms.PictureBox pctrB_Image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

