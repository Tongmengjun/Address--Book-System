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
    public partial class Check_Phone : Form
    {
        private string str = "1924295926";
        public Check_Phone()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            DAO Imagedao = new DAO();
            String imagePath = Imagedao.ImageDao(Login.txtLogin_Username);
            if (imagePath != "")
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            label1.Text = new DAO().GetUserName();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void Check_Phone_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phone_BookDataSet5.Phone_View”中。您可以根据需要移动或删除它                SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;
            SqlCommand cmd;
            DAO dao = new DAO();
            String sql2 = "select * from Phone_View1 where Acount_Username = " + Login.txtLogin_Username;
            cmd = dao.Command(sql2);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            try
            {
                sda.Fill(ds, "Phone_View1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Phone_View1";
                dao.Close();
            }
            catch
            {
                MessageBox.Show("显示失败！");
                dao.Close();
                return;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void datagridBind()
        {
            DAO dao = new DAO();
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;
            if (Login.txtLogin_Username.Equals(str))
            {
                String sql1 = "select * from Phone_View";
                cmd = dao.Command(sql1);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                sda.Fill(ds, "Phone_View");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Phone_View";
                dao.Close();
            }
            else
            {
                String sql2 = "select * from Phone_View1 where Acount_Username = " + Login.txtLogin_Username;
                cmd = dao.Command(sql2);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                sda.Fill(ds, "Phone_View1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Phone_View1";
                dao.Close();
            }

        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
             this.datagridBind();
        }
    }
}