
namespace 通讯录信息管路系统
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictrB = new System.Windows.Forms.PictureBox();
            this.btt_Add_Contact = new 通讯录信息管路系统.ButtonX();
            this.button_Search = new 通讯录信息管路系统.ButtonX();
            this.btt_Check_Group = new 通讯录信息管路系统.ButtonX();
            this.btt_Query_Phone = new 通讯录信息管路系统.ButtonX();
            this.btt_Change_Image = new 通讯录信息管路系统.ButtonX();
            this.btt_Modification_Password = new 通讯录信息管路系统.ButtonX();
            this.btt_Manage = new 通讯录信息管路系统.ButtonX();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictrB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜单";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(690, 20);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "  ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictrB
            // 
            this.pictrB.BackColor = System.Drawing.Color.Transparent;
            this.pictrB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictrB.Location = new System.Drawing.Point(272, 181);
            this.pictrB.Name = "pictrB";
            this.pictrB.Size = new System.Drawing.Size(133, 135);
            this.pictrB.TabIndex = 10;
            this.pictrB.TabStop = false;
            // 
            // btt_Add_Contact
            // 
            this.btt_Add_Contact.BackColor = System.Drawing.Color.SeaShell;
            this.btt_Add_Contact.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btt_Add_Contact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btt_Add_Contact.Location = new System.Drawing.Point(72, 146);
            this.btt_Add_Contact.Name = "btt_Add_Contact";
            this.btt_Add_Contact.Size = new System.Drawing.Size(124, 100);
            this.btt_Add_Contact.TabIndex = 3;
            this.btt_Add_Contact.Text = "添加联系人";
            this.btt_Add_Contact.UseVisualStyleBackColor = false;
            this.btt_Add_Contact.Click += new System.EventHandler(this.btt_Add_Contact_Click);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.SeaShell;
            this.button_Search.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Search.Location = new System.Drawing.Point(379, 350);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(124, 100);
            this.button_Search.TabIndex = 7;
            this.button_Search.Text = "查找";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // btt_Check_Group
            // 
            this.btt_Check_Group.BackColor = System.Drawing.Color.SeaShell;
            this.btt_Check_Group.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btt_Check_Group.Location = new System.Drawing.Point(136, 318);
            this.btt_Check_Group.Name = "btt_Check_Group";
            this.btt_Check_Group.Size = new System.Drawing.Size(124, 100);
            this.btt_Check_Group.TabIndex = 6;
            this.btt_Check_Group.Text = "查看分组";
            this.btt_Check_Group.UseVisualStyleBackColor = false;
            this.btt_Check_Group.Click += new System.EventHandler(this.btt_Check_Group_Click);
            // 
            // btt_Query_Phone
            // 
            this.btt_Query_Phone.BackColor = System.Drawing.Color.SeaShell;
            this.btt_Query_Phone.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btt_Query_Phone.Location = new System.Drawing.Point(202, 41);
            this.btt_Query_Phone.Name = "btt_Query_Phone";
            this.btt_Query_Phone.Size = new System.Drawing.Size(124, 100);
            this.btt_Query_Phone.TabIndex = 1;
            this.btt_Query_Phone.Text = "查看电话";
            this.btt_Query_Phone.UseVisualStyleBackColor = false;
            this.btt_Query_Phone.Click += new System.EventHandler(this.btt_Query_Phone_Click);
            // 
            // btt_Change_Image
            // 
            this.btt_Change_Image.BackColor = System.Drawing.Color.SeaShell;
            this.btt_Change_Image.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btt_Change_Image.Location = new System.Drawing.Point(445, 146);
            this.btt_Change_Image.Name = "btt_Change_Image";
            this.btt_Change_Image.Size = new System.Drawing.Size(124, 100);
            this.btt_Change_Image.TabIndex = 4;
            this.btt_Change_Image.Text = "更换头像";
            this.btt_Change_Image.UseVisualStyleBackColor = false;
            this.btt_Change_Image.Click += new System.EventHandler(this.btt_Change_Image_Click);
            // 
            // btt_Modification_Password
            // 
            this.btt_Modification_Password.BackColor = System.Drawing.Color.SeaShell;
            this.btt_Modification_Password.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btt_Modification_Password.ForeColor = System.Drawing.Color.Black;
            this.btt_Modification_Password.Location = new System.Drawing.Point(357, 41);
            this.btt_Modification_Password.Name = "btt_Modification_Password";
            this.btt_Modification_Password.Size = new System.Drawing.Size(124, 100);
            this.btt_Modification_Password.TabIndex = 2;
            this.btt_Modification_Password.Text = "修改密码";
            this.btt_Modification_Password.UseVisualStyleBackColor = false;
            this.btt_Modification_Password.Click += new System.EventHandler(this.btt_Modification_Password_Click);
            // 
            // btt_Manage
            // 
            this.btt_Manage.BackColor = System.Drawing.Color.SeaShell;
            this.btt_Manage.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btt_Manage.Location = new System.Drawing.Point(486, 274);
            this.btt_Manage.Name = "btt_Manage";
            this.btt_Manage.Size = new System.Drawing.Size(124, 100);
            this.btt_Manage.TabIndex = 5;
            this.btt_Manage.Text = "管理联系人";
            this.btt_Manage.UseVisualStyleBackColor = false;
            this.btt_Manage.Click += new System.EventHandler(this.btt_Manage_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 499);
            this.Controls.Add(this.pictrB);
            this.Controls.Add(this.btt_Add_Contact);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.btt_Check_Group);
            this.Controls.Add(this.btt_Query_Phone);
            this.Controls.Add(this.btt_Change_Image);
            this.Controls.Add(this.btt_Modification_Password);
            this.Controls.Add(this.btt_Manage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            //this.Text = "菜单";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictrB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ButtonX btt_Manage;
        private ButtonX btt_Modification_Password;
        private ButtonX btt_Change_Image;
        private ButtonX btt_Query_Phone;
        private ButtonX btt_Check_Group;
        private ButtonX button_Search;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private ButtonX btt_Add_Contact;
        private System.Windows.Forms.PictureBox pictrB;
    }
}