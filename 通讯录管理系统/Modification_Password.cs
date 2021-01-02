using System;
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
    public partial class Modification_Password : Form
    {
        public Modification_Password()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");
        }
        private void btt_Modification_Password_Click(object sender, EventArgs e)
        {
            //获取当前登录用户的登录名
            String modification_Username = Login.txtLogin_Username;
            //获取用户输入的登录密码以及两次新密码
            String login_Pwd = tB_Modif_Password.Text;
            String modif_NewPwd1 = tB_Modif_NewPassword.Text;
            String modif_NewPwd2 = tB_Modif_NewPassword2.Text;
            //判断用户是否输入了新密码
            if (modif_NewPwd1 == "" || modif_NewPwd2 == "")
            {
                MessageBox.Show("不要忘记输入密码了！");
                return;
            }
            //判断两次输入的新密码是否一致
            if (!modif_NewPwd1.Equals(modif_NewPwd2))
            {
                MessageBox.Show("输入的密码不一致哦！");
                return;
            }
            DAO dao = new DAO();
            if (!dao.BooleanAccount(modification_Username, tB_Modif_Password.Text))
            {
                MessageBox.Show("登录密码错误啦！");
                return;
            }
            if (modif_NewPwd1.Equals(login_Pwd))
            {
                MessageBox.Show("宝贝，新密码与原密码相同!");
                return;
            }
            else
            {
                if (dao.Modifi_PassWord(modification_Username, modif_NewPwd1) != 0)
                {
                    MessageBox.Show("修改密码成功思密达！");
                }
                else
                {
                    MessageBox.Show("修改密码失败思密达！");
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
