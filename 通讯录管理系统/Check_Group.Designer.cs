
namespace 通讯录信息管路系统
{
    partial class Check_Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Group));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.phone_BookDataSet3 = new 通讯录信息管路系统.Phone_BookDataSet3();
            this.phoneBookDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone_BookDataSet4 = new 通讯录信息管路系统.Phone_BookDataSet4();
            this.groupViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group_ViewTableAdapter = new 通讯录信息管路系统.Phone_BookDataSet4TableAdapters.Group_ViewTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phone_BookDataSet31 = new 通讯录信息管路系统.Phone_BookDataSet3();
            this.dataGridView1 = new 通讯录信息管路系统.DataGViewX();
            this.分组名字DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总人数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX1 = new 通讯录信息管路系统.ButtonX();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(607, 46);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(568, 40);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(20, 40);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // phone_BookDataSet3
            // 
            this.phone_BookDataSet3.DataSetName = "Phone_BookDataSet3";
            this.phone_BookDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneBookDataSet3BindingSource
            // 
            this.phoneBookDataSet3BindingSource.DataSource = this.phone_BookDataSet3;
            this.phoneBookDataSet3BindingSource.Position = 0;
            // 
            // phone_BookDataSet4
            // 
            this.phone_BookDataSet4.DataSetName = "Phone_BookDataSet4";
            this.phone_BookDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupViewBindingSource
            // 
            this.groupViewBindingSource.DataMember = "Group_View";
            this.groupViewBindingSource.DataSource = this.phone_BookDataSet4;
            // 
            // group_ViewTableAdapter
            // 
            this.group_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(426, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 135);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(429, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "账号";
            // 
            // phone_BookDataSet31
            // 
            this.phone_BookDataSet31.DataSetName = "Phone_BookDataSet3";
            this.phone_BookDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackImage = ((System.Drawing.Image)(resources.GetObject("dataGridView1.BackImage")));
            this.dataGridView1.BackTransparent = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.分组名字DataGridViewTextBoxColumn,
            this.总人数DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.groupViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(358, 396);
            this.dataGridView1.TabIndex = 5;
            // 
            // 分组名字DataGridViewTextBoxColumn
            // 
            this.分组名字DataGridViewTextBoxColumn.DataPropertyName = "分组名字";
            this.分组名字DataGridViewTextBoxColumn.HeaderText = "分组名字";
            this.分组名字DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.分组名字DataGridViewTextBoxColumn.Name = "分组名字DataGridViewTextBoxColumn";
            // 
            // 总人数DataGridViewTextBoxColumn
            // 
            this.总人数DataGridViewTextBoxColumn.DataPropertyName = "总人数";
            this.总人数DataGridViewTextBoxColumn.HeaderText = "总人数";
            this.总人数DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.总人数DataGridViewTextBoxColumn.Name = "总人数DataGridViewTextBoxColumn";
            // 
            // buttonX1
            // 
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX1.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonX1.Location = new System.Drawing.Point(433, 319);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(82, 80);
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "退出";
            this.buttonX1.UseVisualStyleBackColor = false;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Check_Group
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(607, 534);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Check_Group";
            this.Text = "查看分组";
            this.Load += new System.EventHandler(this.Check_Group_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource phoneBookDataSet3BindingSource;
        private Phone_BookDataSet3 phone_BookDataSet3;
        private Phone_BookDataSet4 phone_BookDataSet4;
        private System.Windows.Forms.BindingSource groupViewBindingSource;
        private Phone_BookDataSet4TableAdapters.Group_ViewTableAdapter group_ViewTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Phone_BookDataSet3 phone_BookDataSet31;
        private DataGViewX dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分组名字DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总人数DataGridViewTextBoxColumn;
        private ButtonX buttonX1;
    }
}