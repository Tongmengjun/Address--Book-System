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
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btt_Logout_Click(object sender, EventArgs e)
        {
            //获取用户输入的将要注销的用户名及密码
            String logout_Username = tB_Logout_Username.Text;
            String logout_Password = tB_Logout_Password.Text;
            //判断是否输入了用户名及密码
            if (logout_Username == "" || logout_Password == "")
            {
                MessageBox.Show("注销需要账号和密码哦！");
                return;
            }
            //连接数据库进行数据验证
            //如果密码以及用户名正确，提示用户是否确认注销，确定之后将该用户从数据库中删除
            DAO dao = new DAO();
            if (dao.BooleanAccount(logout_Username, logout_Password))
            {
                //弹出消息框，并获取消息框的返回值
                DialogResult dr = MessageBox.Show("确认要跟我分开吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //如果消息框返回值是Yes，显示新窗体
                if (dr == DialogResult.Yes)
                {
                    dao.DeleteA_C(logout_Username);
                    dao.DeleteAccount(logout_Username, logout_Password);
                    //清空所有文本框
                    tB_Logout_Username.Text = "";
                    tB_Logout_Password.Text = "";
                    ; MessageBox.Show("删除成功！");
                }
                //如果消息框返回值是No，关闭当前窗体
                else if (dr == DialogResult.No)
                {
                    //关闭当前窗体
                    this.Close();
                }
            }
            else if (!dao.BooleanAccount(logout_Username, logout_Password))
            {
                MessageBox.Show("欧尼，账号或密码不正确呢！");
            }
        }
    }
}
