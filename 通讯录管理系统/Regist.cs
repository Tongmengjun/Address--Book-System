using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 通讯录信息管路系统
{
    public partial class Regist : Form
    {
        private Login login;
        //默认头像路径
        public static String imagePath = "C:/Users/Magic Book/Desktop/通讯录信息管理系统/picture/头像1.jpg";
        public Regist()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = System.DateTime.Now.ToString("yyyy-MM-dd MM:hh:ss");
            timer1.Start();
            login = new Login();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = System.DateTime.Now.ToString("yyyy-MM-dd MM:hh:ss");
        }
        private void btt_Regist_Click(object sender, EventArgs e)
        {
            //获取用户注册输入的用户名和密码
            String regist_Username = tB_Regist_Username.Text.Trim();
            String regist_Password1 = tB_Regist_Password1.Text.Trim();
            string regist_Password2 = tB_Regist_Password2.Text.Trim();

            //判断是否输入了用户名和密码
            if (regist_Username == "" || regist_Password1 == "" || regist_Password2 == "")
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }

            //判断两次输入的密码是否一致
            if (!regist_Password1.Equals(regist_Password2))
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                return;
            }


            //连接数据库，判断用户名是否已存在
            DAO dao = new DAO();
            if (dao.BooleanAccount(regist_Username))
            {
                MessageBox.Show("用户名已存在，请重新输入用户名！");
                return;
            }

            //验证通过，将用户输入的数据添加进入数据库;
            if (dao.InsertAccount(regist_Username,regist_Password1,imagePath))
            {
                MessageBox.Show("注册成功！将跳转到登录页面！");
                login = new Login();
                this.Hide();
                login.ShowDialog();
                Application.ExitThread();
            }
        }

        //当点击用户名文本框时给pictureBox中放置一张默认的图片
        private void tB_Regist_Username_MouseClick(object sender, MouseEventArgs e)
        {
            //如果pictureBox为空时显示默认图片
            if (pctrB_Regist_Image.Image == null)
            {
                String imagePath = "C:/Users/Magic Book/Desktop/通讯录信息管理系统/picture/头像1.jpg";
                pctrB_Regist_Image.Image = Image.FromFile(imagePath);
                pctrB_Regist_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void btt_ChangeImage_Click(object sender, EventArgs e)
        {
            //自定义OpenFileDialog打开Windows文件对话框选择文件，并保存路径
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Application.StartupPath + @"\images";
            f.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                imagePath = f.FileName.ToString();
                //将更换的图片显示在注册页面
                pctrB_Regist_Image.Image = Image.FromFile(imagePath);
                //将图片居中显示
                pctrB_Regist_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            return;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:8080/C_Login/login.html");
        }
    }
    public class ButtonX : Button
    {


        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {

            base.OnPaint(e);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);

        }

        protected override void OnMouseEnter(EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Blue), 0, 0, this.Width, this.Height);
            g.Dispose();
        }

    }
}
