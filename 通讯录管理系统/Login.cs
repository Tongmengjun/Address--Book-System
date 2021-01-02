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
	public partial class Login : Form
	{
        //存取用户名
        private Menu menu;
		public static String txtLogin_Username;
		public Login()
		{
			InitializeComponent();
            DAO userdao = new DAO();
            tB_Account_Username.Text = userdao.GetUserName(); ;
            toolStripStatusLabel3.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
        }
        private void ChangeImage()
        {
            DAO imagedao = new DAO();
            String imagepath = imagedao.ImageDao(Login.txtLogin_Username);
            pctrB_Image.Image = Image.FromFile(imagepath);
            pctrB_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrB_Image.Refresh();
        }
        private void btt_Login_Click(object sender, EventArgs e)
        {
			txtLogin_Username = tB_Account_Username.Text.Trim();
			String password = tB_Account_Password.Text.Trim();
			if(txtLogin_Username =="" || password == "")
            {
				MessageBox.Show("请输入用户名和密码！");
				return;
            }
			//连接数据库进行判断
            DAO dao = new DAO();
            if (dao.BooleanAccount(txtLogin_Username, password))
            {
                //打开菜单
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog(this);
                Application.ExitThread();
            }
            else
            {
				MessageBox.Show("账号或密码错误，请重新输入！");
            }
			//清空文本框
			foreach(Control item in this.Controls)
            {
				if(item is TextBox)
                {
					item.Text = "";          
				}
            }
		}

        //注册用户
        private void lb_Regist_Click(object sender, EventArgs e)
        {
			Regist rigist = new Regist();
			rigist.Show();
		}

        //注销用户
        private void lb_Logout_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout();
            logout.Show();
        }

        //点击密码文本框时将登录头像显示在pictureBox控件中
        private void tB_Account_Password_MouseClick(object sender, MouseEventArgs e)
        {
            //获取输入的用户名
            String username = tB_Account_Username.Text.Trim();

            if (username != "")
            {
                DAO dao1 = new DAO();
                if (dao1.BooleanAccount(username))
                {
                    //连接数据库，获取该用户名的头像保存路径
                    //将数据库中读取到的路径放入变量中
                    DAO dao2  = new DAO();
                    String image_Path = dao2.ImageDao(username);
                    pctrB_Image.Image = Image.FromFile(image_Path);
                    //将图片居中显示
                    pctrB_Image.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                else
                {
                    MessageBox.Show("用户名不存在，请重新输入！");
                }
            }
        }
    }
}
