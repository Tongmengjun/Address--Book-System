package com.servlet;

import com.dao.LoginDAO;
import com.entity.Person;
import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.*;
import java.util.List;

@WebServlet(name = "LoginServlet")
public class LoginServlet extends HttpServlet {
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html;charset=utf-8");
        String str;
        Person person = new Person();
        str = "C:/Users/Magic Book/Desktop/通讯录信息管理系统/picture/头像1.jpg";
        person.setId(Integer.parseInt(request.getParameter("id")));
        person.setPassword(request.getParameter("password"));
        person.setImage(str);
        new LoginDAO().add(person);
    }
}
