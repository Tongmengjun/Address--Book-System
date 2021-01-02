<%--
  Created by IntelliJ IDEA.
  User: Magic Book
  Date: 2020/12/30
  Time: 2:01
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java"
         pageEncoding="UTF-8" import="java.util.*" %>
<script src="https://how2j.cn/study/js/jquery/2.0.0/jquery.min.js"></script>
<link href="https://how2j.cn/study/css/bootstrap/3.3.6/bootstrap.min.css" rel="stylesheet">
<script src="https://how2j.cn/study/js/bootstrap/3.3.6/bootstrap.min.js"></script>

<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>注册账号</title>
    <link rel="stylesheet"
          href="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap.min.css"
          integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"
          crossorigin="anonymous">
</head>
<body>
<div class="container">
    <div class="row" style="margin-top: 30px">
        <div class="col-md-4 col-md-offset-4">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <span class="glyphicon glyphicon-plus"></span>注册
                </div>
                <div class="panel-body">
                    <form action="login" method="POST" name="registerForm">
                        <div class="form-group">
                            <%--@declare id="name"--%><label for="name">用户名</label> <input type="text"
                                                                 class="form-control" name="id" placeholder="账号"
                                                                 autofocus="autofocus">
                        </div>
                        <div class="form-group">
                            <%--@declare id="password"--%><label for="password">密码</label> <input type="password"
                                                            class="form-control" name="password" placeholder="密码">
                        </div>
                        <div class="form-group">
                            <%--@declare id="repassword"--%><label for="repassword">重复密码</label> <input type="password"
                                                              class="form-control" name="repassword" placeholder="请重复密码">
                        </div>
                        <button type="submit" class="btn btn-primary"
                                onclick="return checkForm()">注册
                        </button>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
<script
        src="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/js/bootstrap.min.js"
        integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"
        crossorigin="anonymous"></script>
<script type="text/javascript">
    function checkForm() {
        var name = registerForm.name.value;
        var pwd = registerForm.pwd.value;
        var repwd = registerForm.repwd.value;
        //alert(name + pwd + repwd);
        if (name == "" || name == null) {
            alert("请输入用户名");
            registerForm.name.focus();
            return false;
        } else if (pwd == "" || pwd == null) {
            alert("请输入密码");
            registerForm.pwd.focus();
            return false;
        } else if (repwd == "" || repwd == null) {
            alert("请输入重复密码");
            registerForm.repwd.focus();
            return false;
        } else if (pwd != repwd) {
            alert("两次密码输入不一致，请重新输入!");
            registerForm.repwd.focus();
            return false;
        }
        alert('注册成功！');
        return true;
    }
</script>
</body>
</html>