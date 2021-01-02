
namespace 通讯录信息管路系统
{
    partial class Contact_Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact_Manage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contactViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone_BookDataSet2 = new 通讯录信息管路系统.Phone_BookDataSet2();
            this.contact_ViewTableAdapter = new 通讯录信息管路系统.Phone_BookDataSet2TableAdapters.Contact_ViewTableAdapter();
            this.pictrB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Group = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_QQ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_Sex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_Birthday = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_Address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_WorkAddress = new System.Windows.Forms.TextBox();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.Button_Query = new System.Windows.Forms.Button();
            this.Button_Modifi = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.phone_BookDataSet7 = new 通讯录信息管路系统.Phone_BookDataSet7();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter = new 通讯录信息管路系统.Phone_BookDataSet7TableAdapters.ContactTableAdapter();
            this.buttonX1 = new 通讯录信息管路系统.ButtonX();
            this.dataGridView1 = new 通讯录信息管路系统.DataGViewX();
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactQQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactWorkAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contactViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictrB)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contactViewBindingSource
            // 
            this.contactViewBindingSource.DataMember = "Contact_View";
            this.contactViewBindingSource.DataSource = this.phone_BookDataSet2;
            // 
            // phone_BookDataSet2
            // 
            this.phone_BookDataSet2.DataSetName = "Phone_BookDataSet2";
            this.phone_BookDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contact_ViewTableAdapter
            // 
            this.contact_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // pictrB
            // 
            this.pictrB.BackColor = System.Drawing.Color.Transparent;
            this.pictrB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictrB.Location = new System.Drawing.Point(837, 1);
            this.pictrB.Name = "pictrB";
            this.pictrB.Size = new System.Drawing.Size(133, 135);
            this.pictrB.TabIndex = 1;
            this.pictrB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(832, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "账 号";
            // 
            // tB_ID
            // 
            this.tB_ID.Location = new System.Drawing.Point(143, 366);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(143, 30);
            this.tB_ID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "联系人账号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(292, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "姓名:";
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(360, 366);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(143, 30);
            this.tB_Name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(509, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "分组:";
            // 
            // tB_Group
            // 
            this.tB_Group.Location = new System.Drawing.Point(577, 366);
            this.tB_Group.Name = "tB_Group";
            this.tB_Group.Size = new System.Drawing.Size(143, 30);
            this.tB_Group.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "电话:";
            // 
            // tB_Phone
            // 
            this.tB_Phone.Location = new System.Drawing.Point(80, 416);
            this.tB_Phone.Name = "tB_Phone";
            this.tB_Phone.Size = new System.Drawing.Size(143, 30);
            this.tB_Phone.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(229, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "QQ:";
            // 
            // tB_QQ
            // 
            this.tB_QQ.Location = new System.Drawing.Point(277, 416);
            this.tB_QQ.Name = "tB_QQ";
            this.tB_QQ.Size = new System.Drawing.Size(143, 30);
            this.tB_QQ.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(426, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "性别:";
            // 
            // tB_Sex
            // 
            this.tB_Sex.Location = new System.Drawing.Point(494, 416);
            this.tB_Sex.Name = "tB_Sex";
            this.tB_Sex.Size = new System.Drawing.Size(143, 30);
            this.tB_Sex.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(658, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "生日:";
            // 
            // tB_Birthday
            // 
            this.tB_Birthday.Location = new System.Drawing.Point(726, 416);
            this.tB_Birthday.Name = "tB_Birthday";
            this.tB_Birthday.Size = new System.Drawing.Size(143, 30);
            this.tB_Birthday.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(12, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "邮箱:";
            // 
            // tB_Email
            // 
            this.tB_Email.Location = new System.Drawing.Point(80, 464);
            this.tB_Email.Name = "tB_Email";
            this.tB_Email.Size = new System.Drawing.Size(143, 30);
            this.tB_Email.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(229, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "住址:";
            // 
            // tB_Address
            // 
            this.tB_Address.Location = new System.Drawing.Point(296, 464);
            this.tB_Address.Name = "tB_Address";
            this.tB_Address.Size = new System.Drawing.Size(226, 30);
            this.tB_Address.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(538, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "工作地址:";
            // 
            // tB_WorkAddress
            // 
            this.tB_WorkAddress.Location = new System.Drawing.Point(643, 464);
            this.tB_WorkAddress.Name = "tB_WorkAddress";
            this.tB_WorkAddress.Size = new System.Drawing.Size(226, 30);
            this.tB_WorkAddress.TabIndex = 22;
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.AutoSize = true;
            this.Button_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Refresh.Location = new System.Drawing.Point(847, 181);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(75, 32);
            this.Button_Refresh.TabIndex = 23;
            this.Button_Refresh.Text = "刷新";
            this.Button_Refresh.UseVisualStyleBackColor = false;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Button_Query
            // 
            this.Button_Query.AutoSize = true;
            this.Button_Query.BackColor = System.Drawing.Color.Transparent;
            this.Button_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Query.Location = new System.Drawing.Point(847, 237);
            this.Button_Query.Name = "Button_Query";
            this.Button_Query.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Query.Size = new System.Drawing.Size(75, 32);
            this.Button_Query.TabIndex = 24;
            this.Button_Query.Text = "查询";
            this.Button_Query.UseVisualStyleBackColor = false;
            this.Button_Query.Click += new System.EventHandler(this.Button_Query_Click);
            // 
            // Button_Modifi
            // 
            this.Button_Modifi.AutoSize = true;
            this.Button_Modifi.BackColor = System.Drawing.Color.Transparent;
            this.Button_Modifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Modifi.Location = new System.Drawing.Point(847, 291);
            this.Button_Modifi.Name = "Button_Modifi";
            this.Button_Modifi.Size = new System.Drawing.Size(75, 32);
            this.Button_Modifi.TabIndex = 25;
            this.Button_Modifi.Text = "修改";
            this.Button_Modifi.UseVisualStyleBackColor = false;
            this.Button_Modifi.Click += new System.EventHandler(this.Button_Modifi_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.AutoSize = true;
            this.Button_Delete.BackColor = System.Drawing.Color.Transparent;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Location = new System.Drawing.Point(847, 349);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 32);
            this.Button_Delete.TabIndex = 26;
            this.Button_Delete.Text = "删除";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 46);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(939, 40);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(20, 40);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // phone_BookDataSet7
            // 
            this.phone_BookDataSet7.DataSetName = "Phone_BookDataSet7";
            this.phone_BookDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.phone_BookDataSet7;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // buttonX1
            // 
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX1.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonX1.Location = new System.Drawing.Point(875, 416);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(87, 68);
            this.buttonX1.TabIndex = 29;
            this.buttonX1.Text = "退出";
            this.buttonX1.UseVisualStyleBackColor = false;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackImage = ((System.Drawing.Image)(resources.GetObject("dataGridView1.BackImage")));
            this.dataGridView1.BackTransparent = true;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactIDDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.gPNameDataGridViewTextBoxColumn,
            this.contactPhoneDataGridViewTextBoxColumn,
            this.contactSexDataGridViewTextBoxColumn,
            this.contactBirthdayDataGridViewTextBoxColumn,
            this.contactQQDataGridViewTextBoxColumn,
            this.contactAddressDataGridViewTextBoxColumn,
            this.contactEmailDataGridViewTextBoxColumn,
            this.contactWorkAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactViewBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(814, 359);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "Contact_ID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "联系人账号";
            this.contactIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            this.contactIDDataGridViewTextBoxColumn.Width = 76;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "Contact_Name";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.contactNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // gPNameDataGridViewTextBoxColumn
            // 
            this.gPNameDataGridViewTextBoxColumn.DataPropertyName = "GP_Name";
            this.gPNameDataGridViewTextBoxColumn.HeaderText = "分组";
            this.gPNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gPNameDataGridViewTextBoxColumn.Name = "gPNameDataGridViewTextBoxColumn";
            this.gPNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            this.contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "Contact_Phone";
            this.contactPhoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.contactPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            this.contactPhoneDataGridViewTextBoxColumn.Width = 76;
            // 
            // contactSexDataGridViewTextBoxColumn
            // 
            this.contactSexDataGridViewTextBoxColumn.DataPropertyName = "Contact_Sex";
            this.contactSexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.contactSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactSexDataGridViewTextBoxColumn.Name = "contactSexDataGridViewTextBoxColumn";
            this.contactSexDataGridViewTextBoxColumn.Width = 76;
            // 
            // contactBirthdayDataGridViewTextBoxColumn
            // 
            this.contactBirthdayDataGridViewTextBoxColumn.DataPropertyName = "Contact_Birthday";
            this.contactBirthdayDataGridViewTextBoxColumn.HeaderText = "生日";
            this.contactBirthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactBirthdayDataGridViewTextBoxColumn.Name = "contactBirthdayDataGridViewTextBoxColumn";
            this.contactBirthdayDataGridViewTextBoxColumn.Width = 77;
            // 
            // contactQQDataGridViewTextBoxColumn
            // 
            this.contactQQDataGridViewTextBoxColumn.DataPropertyName = "Contact_QQ";
            this.contactQQDataGridViewTextBoxColumn.HeaderText = "QQ";
            this.contactQQDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactQQDataGridViewTextBoxColumn.Name = "contactQQDataGridViewTextBoxColumn";
            this.contactQQDataGridViewTextBoxColumn.Width = 76;
            // 
            // contactAddressDataGridViewTextBoxColumn
            // 
            this.contactAddressDataGridViewTextBoxColumn.DataPropertyName = "Contact_Address";
            this.contactAddressDataGridViewTextBoxColumn.HeaderText = "住址";
            this.contactAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactAddressDataGridViewTextBoxColumn.Name = "contactAddressDataGridViewTextBoxColumn";
            this.contactAddressDataGridViewTextBoxColumn.Width = 76;
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            this.contactEmailDataGridViewTextBoxColumn.DataPropertyName = "Contact_Email";
            this.contactEmailDataGridViewTextBoxColumn.HeaderText = "邮箱";
            this.contactEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            this.contactEmailDataGridViewTextBoxColumn.Width = 76;
            // 
            // contactWorkAddressDataGridViewTextBoxColumn
            // 
            this.contactWorkAddressDataGridViewTextBoxColumn.DataPropertyName = "Contact_WorkAddress";
            this.contactWorkAddressDataGridViewTextBoxColumn.HeaderText = "工作地址";
            this.contactWorkAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactWorkAddressDataGridViewTextBoxColumn.Name = "contactWorkAddressDataGridViewTextBoxColumn";
            this.contactWorkAddressDataGridViewTextBoxColumn.Width = 76;
            // 
            // Contact_Manage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 565);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Modifi);
            this.Controls.Add(this.Button_Query);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.tB_WorkAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tB_Address);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tB_Email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tB_Birthday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tB_Sex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tB_QQ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tB_Phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tB_Group);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictrB);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Contact_Manage";
            this.Text = "管理联系人";
            this.Load += new System.EventHandler(this.Contact_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictrB)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Phone_BookDataSet2 phone_BookDataSet2;
        private System.Windows.Forms.BindingSource contactViewBindingSource;
        private Phone_BookDataSet2TableAdapters.Contact_ViewTableAdapter contact_ViewTableAdapter;
        private System.Windows.Forms.PictureBox pictrB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_Group;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_QQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_Sex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_Birthday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tB_Email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_Address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tB_WorkAddress;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Button Button_Query;
        private System.Windows.Forms.Button Button_Modifi;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private DataGViewX dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactQQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactWorkAddressDataGridViewTextBoxColumn;
        private ButtonX buttonX1;
        private Phone_BookDataSet7 phone_BookDataSet7;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private Phone_BookDataSet7TableAdapters.ContactTableAdapter contactTableAdapter;
    }
}