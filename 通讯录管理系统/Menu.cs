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
    public partial class Menu : Form
    {
        public String imagepath;
        public Menu()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString();
            timer1.Start();
        }
        public void change(String str)
        {
            imagepath = str;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToString();
            DAO imagedao = new DAO();
            imagepath = imagedao.ImageDao(Login.txtLogin_Username);
            Console.WriteLine(imagepath);
            if (imagepath != "")
            {
                try
                {
                    pictrB.Image = Image.FromFile(imagepath);
                    pictrB.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictrB.Refresh();
                }
                catch
                {

                }
            }
        }

        //添加联系人
        private void btt_Add_Contact_Click(object sender, EventArgs e)
        {
            Addcount add = new Addcount();
            add.Show();
        }
        //修改密码
        public void btt_Modification_Password_Click(object sender, EventArgs e)
        {
            Modification_Password modif_Pwd = new Modification_Password();
            modif_Pwd.Show();
           
        }

        private void btt_Change_Image_Click(object sender, EventArgs e)
        {
            Change_Image change_Image = new Change_Image();
            change_Image.change = new Change_Image.mydelegate(change);
            change_Image.Show(this);
        }
        
        //管理联系人
        private void btt_Manage_Click(object sender, EventArgs e)
        {
            Contact_Manage cm = new Contact_Manage();
            cm.Show();
        }
        //查看分组
        private void btt_Check_Group_Click(object sender, EventArgs e)
        {
            Check_Group CG = new Check_Group();
            CG.Show();
        }
        //查看电话
        private void btt_Query_Phone_Click(object sender, EventArgs e)
        {
            Check_Phone CP = new Check_Phone();
            CP.Show();
        }
        //通过信息查看数据
        private void button_Search_Click(object sender, EventArgs e)
        {
            Search sc = new Search();
            sc.Show();
        }
    }
    
}
