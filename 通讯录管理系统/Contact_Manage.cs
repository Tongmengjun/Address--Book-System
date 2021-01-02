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
using System.Configuration;


namespace 通讯录信息管路系统
{
    public partial class Contact_Manage : Form
    {
        private string str = "1924295926";
        private string username; 
        private static string sqlcon = "server =.; database = Phone_Book; uid = sa; pwd = tmj20000509";
        public Contact_Manage()
        {
            InitializeComponent();
            DAO dao = new DAO();
            String imagepath = dao.ImageDao(Login.txtLogin_Username);
            if (imagepath != "")
            {
                pictrB.Image = Image.FromFile(imagepath);
                pictrB.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            label1.Text = Login.txtLogin_Username;
            //this.contact_ViewTableAdapter.Fill(this.phone_BookDataSet2.Contact_View);
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }
        //用于实时刷新数据
        private void datagridBind()
        {
            DAO dao = new DAO();
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;
            if (Login.txtLogin_Username.Equals(str))
            {
                String sql1 = "select * from Contact_View";
                cmd = dao.Command(sql1);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Contact_View");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Contact_View";
                    dao.Close();
                }
                catch
                {
                    MessageBox.Show("失败！");
                    dao.Close();
                    return;
                }
            }
            else
            {
                String sql2 = "select * from ContactView1_View where Acount_Username = " + Login.txtLogin_Username;
                cmd = dao.Command(sql2);
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                try
                {
                    sda.Fill(ds, "Contact_View");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Contact_View";
                    dao.Close();
                }
                catch
                {
                    MessageBox.Show("失败！");
                    dao.Close();
                    return;
                }
            }
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        //修改
        private void Button_Modifi_Click(object sender, EventArgs e)
        {

            if (tB_ID.Text != "")
            {
                String result = "";
                /*账号
                if (tB_ID.Text != "")
                {
                    result = result + ",Contact_ID='" + tB_ID.Text + "'";
                }*/
                //姓名
                if (tB_Name.Text != "")
                {
                    result = result + ",Contact_Name='" + tB_Name.Text + "'";
                }
                //分组
                if (tB_Group.Text != "")
                {
                    result = result + ",GP_Name='" + tB_Group.Text + "'";
                }
                //电话
                if (tB_Phone.Text != "")
                {
                    result = result + ",Contact_Phone='" + tB_Phone.Text + "'";
                }
                //性别
                if (tB_Sex.Text != "")
                {
                    result = result + ",Contact_Sex='" + tB_Sex.Text + "'";
                }
                //生日
                if (tB_Birthday.Text != "")
                {
                    result = result + ",Contact_Birthday='" + tB_Birthday.Text + "'";
                }
                //QQ
                if (tB_QQ.Text != "")
                {
                    result = result + ",Contact_QQ='" + tB_QQ.Text + "'";
                }
                //住址
                if (tB_Address.Text != "")
                {
                    result = result + ",Contact_Address='" + tB_Address.Text + "'";
                }
                //Email
                if (tB_Email.Text != "")
                {
                    result = result + ",Contact_Email='" + tB_Email.Text + "'";
                }
                //工作地址 
                if (tB_WorkAddress.Text != "")
                {
                    result = result + ",Contact_WorkAddress='" + tB_WorkAddress.Text + "'";
                }
                
                String sqlcom = "update Contact_View set Contact_ID='" + tB_ID.Text + "'" + result + " where Contact_ID = " + username;
                Console.WriteLine(sqlcom);
                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand com = new SqlCommand(sqlcom, con);
                con.Open();
                try
                {
                    int eq = com.ExecuteNonQuery();
                    Console.WriteLine(eq);
                    if (eq != 0)
                    {
                        MessageBox.Show("修改成功思密达！");
                        this.datagridBind();
                    }
                    else
                        MessageBox.Show("修改失败思密达！");
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("修改失败思密达！");
                    con.Close();
                    return;
                }

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else MessageBox.Show("请先点击联系人再进行修改操作！");

        }
        //显示数据在TextBox
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            tB_ID.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //tB_ID.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tB_Name.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tB_Group.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tB_Phone.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tB_Sex.Text  = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tB_Birthday.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tB_QQ.Text = this.dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tB_Address.Text = this.dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            tB_Email.Text = this.dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            tB_WorkAddress.Text = this.dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            username=tB_ID.Text;
        }
        //删除
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (tB_ID.Text == "")
            {
                MessageBox.Show("账号不能为空！");
                return;
            }
            String name = tB_ID.Text;
            Boolean status = new DAO().DeleteContact(name);
            if (status)
            {
                MessageBox.Show("删除成功！");
                return;
            }
            else
            {
                MessageBox.Show("删除失败！");
                return;
            }
            
        }
        //刷新
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            this.datagridBind();
        }
        //查询 
        private void Button_Query_Click(object sender, EventArgs e)
        {
            //this.contactTableAdapter.Fill(this.phone_BookDataSet7.Contact);
            DAO dao = new DAO();
            String sql = "select * from ContactView1_View where Acount_Username = " + Login.txtLogin_Username;
            SqlCommand cmd = dao.Command(sql);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds, "ContactView1_View");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ContactView1_View";
                dao.Close();
            }
            catch
            {
                MessageBox.Show("查询失败！");
                dao.Close();
                return;
            }
        }
        //初始数据显示
        private void Contact_Manage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phone_BookDataSet7.Contact”中。您可以根据需要移动或删除它。
            //this.contactTableAdapter.Fill(this.phone_BookDataSet7.Contact);
            DAO dao = new DAO();
            String sql = "select * from ContactView1_View where Acount_Username = " + Login.txtLogin_Username;
            SqlCommand cmd = dao.Command(sql);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "ContactView1_View");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ContactView1_View";
            dao.Close();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
