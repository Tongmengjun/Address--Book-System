﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录信息管路系统
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phone_BookDataSet8.Contact_View”中。您可以根据需要移动或删除它。
            this.contact_ViewTableAdapter.Fill(this.phone_BookDataSet8.Contact_View);

        }
    }
}
