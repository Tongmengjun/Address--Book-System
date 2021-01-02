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
    public partial class Search : Form
    {
        public Search()
        {
            //初始化label，pictureBox,time的数据
            InitializeComponent();
            label1.Text = Login.txtLogin_Username;
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            DAO imagedao = new DAO();
            String imagepath = imagedao.ImageDao(Login.txtLogin_Username);
            if (imagepath != "")
            {
                pictureBox1.Image = Image.FromFile(imagepath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //点击将Check_ContactPhone函数的数据填充
            DAO dao = new DAO();
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;
            if (Login.txtLogin_Username == "1924295926")
            {
                String sql1 = "select * from  Check_ContactPhone(" + textBox1.Text + ")";
                cmd = dao.Command(sql1);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
            }
            else
            {
                String sql2 = "select * from  Check_ContactPhone(" + textBox1.Text + ") where Acount_Username = " + Login.txtLogin_Username;
                cmd = dao.Command(sql2);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
            }
            try
            {
                sda.Fill(ds, "Check_ContactPhone");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Check_ContactPhone";
                dao.Close();
            }
            catch
            {
                MessageBox.Show("输入的数据错误！");
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //按账号查询信息
            DAO dao = new DAO();
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;
            if (Login.txtLogin_Username == "1924295926")
            {
                String sql1 = "select * from  Check_Contact(" + textBox1.Text + ")";
                cmd = dao.Command(sql1);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
            }
            else
            {
                String sql2 = "select * from  Check_Contact(" + textBox1.Text + ") where Acount_Username = " + Login.txtLogin_Username;
                cmd = dao.Command(sql2);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
            }
            try
            {
                sda.Fill(ds, "Check_Contact");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Check_Contact";
                dao.Close();
            }
            catch
            {
                MessageBox.Show("输入的数据错误！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //按名字查询信息
            try
            {
                DAO dao = new DAO();
                SqlCommand cmd;
                SqlDataAdapter sda;
                DataSet ds;
                if (Login.txtLogin_Username == "1924295926")
                {
                    String sql1 = "select * from  Check_ContactName('" + textBox1.Text + "')";
                    cmd = dao.Command(sql1);
                    sda = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    sda.Fill(ds, "Check_ContactName");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Check_ContactName";
                    dao.Close();
                }
                else
                {
                    String sql2 = "select * from Check_ContactName('" + textBox1.Text + "') where Acount_Username = " + Login.txtLogin_Username;
                    Console.WriteLine(sql2);
                    cmd = dao.Command(sql2);
                    sda = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    sda.Fill(ds, "Check_ContactName");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Check_ContactName";
                    dao.Close();
                }
            }
            catch
            {
                {
                    MessageBox.Show("输入的数据错误！");
                }
            }
        }
    }
}
