package com.dao;

import com.entity.Person;

import java.sql.*;

/**
 * @ClassName LoginDAO
 * @Author $童一
 * @Description $
 * @Param $
 * @return $
 * @Date $ $
 **/

public class LoginDAO {
    public LoginDAO() {
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
            System.out.println("加载数据库失败");
        }
    }

    public Connection getConnection() throws SQLException {
        return DriverManager.getConnection("jdbc:sqlserver://localhost:1433; DatabaseName=Phone_Book", "sa", "tmj20000509");
    }

    public void add(Person person){
        String sql = "insert into Account values(?,?,?)";
        try(Connection conn=getConnection(); PreparedStatement ps = conn.prepareStatement(sql);){
            ps.setInt(1,person.id);
            ps.setString(2,person.password);
            ps.setString(3,person.image);
            ps.execute();
        }catch (SQLException e){
            e.printStackTrace();
        }
    }
}
