using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 通讯录信息管路系统
{
    class DAO
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public DAO()
        {

        }

        //连接数据库
        public SqlConnection Connection()
        {
            string sqlcon = "server=.;database=Phone_Book;uid=sa;pwd=tmj20000509";
            con = new SqlConnection(sqlcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //关闭数据库
        public void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
        //执行命令
        public SqlCommand Command(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection());
            return cmd;
        }
        //判断是否有相同账号，避免账号重复
        public Boolean BooleanAccount(String Name)
        {
            String sqlcom = "select * from Account where Account_Username=" + Name;
            cmd = Command(sqlcom);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    con.Close();
                    return true;
                }
                else
                    con.Close();
                    return false;
            }
            catch
            {
                con.Close();
                return false;
            }
        }
        //判断输入的账号是否正确
        public Boolean BooleanAccount(String Name, String Password)
        {
            string sqlcom = "select * from Account where Account_Username=" + Name + "and Account_Password='" + Password + "'";
            cmd = Command(sqlcom);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    con.Close();
                    return true;
                }
                else
                    con.Close();
                    return false;
            }
            catch
            {
                con.Close();
                return false;
            }
            
            
        }
        //注销账号
        public Boolean DeleteAccount(String Name,String Password)
        {
            string sqlcom = "delete from Account where Account_Username = "+ Name + "and Account_Password='" + Password + "'";
            cmd = Command(sqlcom);
            try
            {
                int status = cmd.ExecuteNonQuery();
                if (status != 0)
                {
                    con.Close();
                    return true;
                }
                else
                    con.Close();
                    return false;
            }
            catch
            {
                con.Close();
                return false;
            }
        }
        //返回图片地址
        public String ImageDao(String Name)
        {
            String sqlcom = "select Account_Image from Account where Account_Username = " + Name;
            cmd = Command(sqlcom);
            try
            {
                object obj = cmd.ExecuteScalar();
                String Image_Path = obj.ToString();
                con.Close();
                return Image_Path;
            }
            catch
            {
                return null;
            }
        }
        //插入数据
        public Boolean InsertAccount(String regist_Username, String regist_Password1, String imagePath)
        {
            String sqlcom = " insert into Account(Account_Username,Account_Password,Account_Image) values(" + regist_Username + ",'" + regist_Password1 + "','" + imagePath + "')";
            cmd = Command(sqlcom);
            int eq = cmd.ExecuteNonQuery();
            try
            {
                if (eq != 0)
                {
                    con.Close();
                    return true;
                }
                else
                    con.Close();
                    return false;
            }
            catch
            {
                con.Close();
                return false;
            }
        }
        //修改密码
        public int Modifi_PassWord(String Name, String PassWord)
        {
            String sqlcom = "update Account set Account_Password='" + PassWord + "' where Account_Username=" + Name;
            cmd = Command(sqlcom);
            try
            {
                int eq = cmd.ExecuteNonQuery();
                con.Close();
                return eq;
            }
            catch
            {
                con.Close();
                return 0;
            }
        }

        //更换头像
        public int Modifi_Image() 
        {
            String sqlcom = "update Account set Account_Image='" + Regist.imagePath + "' where Account_Username='" + Login.txtLogin_Username + "'";
            cmd = Command(sqlcom);
            try
            {
                int status = cmd.ExecuteNonQuery();
                con.Close();
                return status;
            }
            catch
            {
                return 0;
            }
        }

        //获取账号
        public String GetUserName()
        {
            String sqlcom = "select top 1 Account_Username from Account order by Account_Username desc";
            cmd = Command(sqlcom);
            try
            {
                Object obj = cmd.ExecuteScalar();
                String username = obj.ToString();
                con.Close();
                return username;
            }
            catch
            {
                return null;
            }
        }
        public void DeleteA_C(String name)
        {
            String sqlcon = "delete from Contact where Acount_Username =" + name;
            cmd = Command(sqlcon);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        //删除联系人
        public Boolean DeleteContact(String Name)
        {
            String sqlcon = "delete from Contact_View where Contact_ID =" + Name;
            cmd = Command(sqlcon);
            try
            {
                if (cmd.ExecuteNonQuery() != 0)
                {
                    con.Close();
                    return true;
                }
                else
                    con.Close();
                    return false;
            }
            catch
            {
                con.Close();
                return false;
            }
        }

        public Boolean GetContact(String Name)
        {
            String sqlcon = "select * from Contact where Contact_ID = " + Name;
            Console.WriteLine(sqlcon);
            cmd = Command(sqlcon);
            try
            {
                if (cmd.ExecuteNonQuery() != 0)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch
            {
                con.Close();
                return false;
            }
        }
    }
}
