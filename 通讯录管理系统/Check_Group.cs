using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录信息管路系统
{
    public partial class Check_Group : Form
    {
        public Check_Group()
        {
            InitializeComponent();
            DAO Imagedao = new DAO();
            String imagePath = Imagedao.ImageDao(Login.txtLogin_Username);
            if (imagePath != "")
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            label1.Text = Login.txtLogin_Username;
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH::mm:ss");
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH::mm:ss");
        }

        private void Check_Group_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phone_BookDataSet4.Group_View”中。您可以根据需要移动或删除它。
            if (Login.txtLogin_Username == "1924295926")
            {
                this.group_ViewTableAdapter.Fill(this.phone_BookDataSet4.Group_View);
            }
            else
            {
                DAO dao = new DAO();
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataSet ds;
                Console.WriteLine(Login.txtLogin_Username);
                String sql2 = "select * from Group_View1 where 账号 = " + Login.txtLogin_Username;
                cmd = dao.Command(sql2);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Group_View1");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Group_View1";
                    dao.Close();
                }
                catch
                {
                    MessageBox.Show("显示失败！");
                    dao.Close();
                    return;
                }
                
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
