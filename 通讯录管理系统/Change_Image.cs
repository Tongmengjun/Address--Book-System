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
    public partial class Change_Image : Form
    {
        public delegate void mydelegate(string str);
        public mydelegate change;
        public Change_Image()
        {
            InitializeComponent();
            DAO Imagedao = new DAO();
            String imagePath = Imagedao.ImageDao(Login.txtLogin_Username);
            if (imagePath != "")
            {
                pictrB1_Image.Image = Image.FromFile(imagePath);
                pictrB1_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            toolStripStatusLabel3.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btt_Select_Image_Click(object sender, EventArgs e)
        {
            //自定义OpenFileDialog打开Windows文件对话框选择文件，并保存路径
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Application.StartupPath + @"\images";
            f.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                Regist.imagePath = f.FileName.ToString();
                //将更换的图片显示在注册页面
                pictrB1_Image.Image = Image.FromFile(Regist.imagePath);
                //将图片居中显示
                pictrB1_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            return;
        }

        private void btt_Change_Image_Click(object sender, EventArgs e)
        {
            if (pictrB1_Image.Image != null)
            {
                DAO dao = new DAO();
                try
                {
                    int eq = dao.Modifi_Image();
                    if (eq != 0)
                    {
                        change(Regist.imagePath);
                        MessageBox.Show("头像更换成功！");
                    }
                    else 
                        MessageBox.Show("头像更换失败！");
                }
                catch
                {
                    MessageBox.Show("头像更换失败！");
                }
                
            }
            else 
                MessageBox.Show("请选择图片!");
        }

        public static implicit operator Change_Image(Menu v)
        {
            throw new NotImplementedException();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
