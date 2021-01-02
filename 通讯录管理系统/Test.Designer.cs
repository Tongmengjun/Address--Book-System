
namespace 通讯录信息管路系统
{
    partial class Test
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phone_BookDataSet8 = new 通讯录信息管路系统.Phone_BookDataSet8();
            this.contactViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contact_ViewTableAdapter = new 通讯录信息管路系统.Phone_BookDataSet8TableAdapters.Contact_ViewTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(220, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // phone_BookDataSet8
            // 
            this.phone_BookDataSet8.DataSetName = "Phone_BookDataSet8";
            this.phone_BookDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactViewBindingSource
            // 
            this.contactViewBindingSource.DataMember = "Contact_View";
            this.contactViewBindingSource.DataSource = this.phone_BookDataSet8;
            // 
            // contact_ViewTableAdapter
            // 
            this.contact_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "Contact_ID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "Contact_ID";
            this.contactIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            this.contactIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "Contact_Name";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "Contact_Name";
            this.contactNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // gPNameDataGridViewTextBoxColumn
            // 
            this.gPNameDataGridViewTextBoxColumn.DataPropertyName = "GP_Name";
            this.gPNameDataGridViewTextBoxColumn.HeaderText = "GP_Name";
            this.gPNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gPNameDataGridViewTextBoxColumn.Name = "gPNameDataGridViewTextBoxColumn";
            this.gPNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            this.contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "Contact_Phone";
            this.contactPhoneDataGridViewTextBoxColumn.HeaderText = "Contact_Phone";
            this.contactPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            this.contactPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactSexDataGridViewTextBoxColumn
            // 
            this.contactSexDataGridViewTextBoxColumn.DataPropertyName = "Contact_Sex";
            this.contactSexDataGridViewTextBoxColumn.HeaderText = "Contact_Sex";
            this.contactSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactSexDataGridViewTextBoxColumn.Name = "contactSexDataGridViewTextBoxColumn";
            this.contactSexDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactBirthdayDataGridViewTextBoxColumn
            // 
            this.contactBirthdayDataGridViewTextBoxColumn.DataPropertyName = "Contact_Birthday";
            this.contactBirthdayDataGridViewTextBoxColumn.HeaderText = "Contact_Birthday";
            this.contactBirthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactBirthdayDataGridViewTextBoxColumn.Name = "contactBirthdayDataGridViewTextBoxColumn";
            this.contactBirthdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactQQDataGridViewTextBoxColumn
            // 
            this.contactQQDataGridViewTextBoxColumn.DataPropertyName = "Contact_QQ";
            this.contactQQDataGridViewTextBoxColumn.HeaderText = "Contact_QQ";
            this.contactQQDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactQQDataGridViewTextBoxColumn.Name = "contactQQDataGridViewTextBoxColumn";
            this.contactQQDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactAddressDataGridViewTextBoxColumn
            // 
            this.contactAddressDataGridViewTextBoxColumn.DataPropertyName = "Contact_Address";
            this.contactAddressDataGridViewTextBoxColumn.HeaderText = "Contact_Address";
            this.contactAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactAddressDataGridViewTextBoxColumn.Name = "contactAddressDataGridViewTextBoxColumn";
            this.contactAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            this.contactEmailDataGridViewTextBoxColumn.DataPropertyName = "Contact_Email";
            this.contactEmailDataGridViewTextBoxColumn.HeaderText = "Contact_Email";
            this.contactEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            this.contactEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactWorkAddressDataGridViewTextBoxColumn
            // 
            this.contactWorkAddressDataGridViewTextBoxColumn.DataPropertyName = "Contact_WorkAddress";
            this.contactWorkAddressDataGridViewTextBoxColumn.HeaderText = "Contact_WorkAddress";
            this.contactWorkAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactWorkAddressDataGridViewTextBoxColumn.Name = "contactWorkAddressDataGridViewTextBoxColumn";
            this.contactWorkAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_BookDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Phone_BookDataSet8 phone_BookDataSet8;
        private System.Windows.Forms.BindingSource contactViewBindingSource;
        private Phone_BookDataSet8TableAdapters.Contact_ViewTableAdapter contact_ViewTableAdapter;
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
    }
}