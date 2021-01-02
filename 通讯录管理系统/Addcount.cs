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
    public partial class Addcount : Form
    {
        public Addcount()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void btt_save_Click(object sender, EventArgs e)
        {
            /*if(new DAO().GetContact(tB_CTID.Text))
            {
                MessageBox.Show("已经存在相同账号！");
                return;
            }
            else if (tB_Name.Text.Length == 0)
            {
                MessageBox.Show("姓名怎么能不知道呢！");
                return;
            }
            else if (tB_Phone.Text.Length == 0)
            {
                MessageBox.Show("难道连电话都不知道吗！");
                return;
            }
            else if (tB_CTID.Text.Length == 0)
            {
                MessageBox.Show("联系人账号无法为空哦！");
                return;
            }
            else if (tB_CTGP.Text.Length == 0)
            {
                MessageBox.Show("麻烦给个分组欧尼酱！");
                return;
            }
            else
            {*/
                //数据库操作
                string sqlcon = "server=.;database=Phone_Book;uid=sa;pwd=tmj20000509";
                string sqlcom = "insert into Contact values("+ tB_CTID.Text + "," + Login.txtLogin_Username + ",'" + tB_Name.Text + "','" + tB_CTGP.Text + "','"
                + tB_Phone.Text + "','" + tB_CTSex.Text + "','" + tB_CTBirthday.Text + "'," + tB_QQ.Text + ",'"
                + tB_CTAddress.Text + "','" + tB_Email.Text + "','" + tB_CTWorkAddress.Text + "')";
                //执行添加操作
                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand com = new SqlCommand(sqlcom, con);
                con.Open();
                try
                {
                    int eq = com.ExecuteNonQuery();
                    if (eq != 0)
                    {
                        MessageBox.Show("添加成功了思密达!");
                    }
                    con.Close();
                    //清空所有文本框
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("添加失败了思密达!");
                    return;
                }
               
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
