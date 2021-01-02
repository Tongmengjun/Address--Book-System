create database Phone_Book
on primary
(                                  --主文件
	name = 'Phone_Book_data1',
	filename = 'D:\童梦君\数据库代码\通讯录管理系统\Phone_Book_data1.mdf',
	size = 10MB,
	maxsize = 50MB,
	filegrowth = 1 MB
),
(								   --辅助文件
	name = 'Phone_Book_data2',
	filename = 'D:\童梦君\数据库代码\通讯录管理系统\Phone_Book_data2.ndf',
	size = 10MB,
	maxsize = 50MB,
	filegrowth = 1 MB
)
log on
(									--日志文件
	name = 'Phone_Book_log',
	filename = 'D:\童梦君\数据库代码\通讯录管理系统\Phone_Book_log.ldf',
	size = 10MB,
	maxsize = 50MB,
	filegrowth = 1 MB
)
--用户表
create table Account
(
	Account_Username bigint primary key,  --用户账号
	Account_Password varchar(50) not null,  --用户密码
	Account_Image varchar(100)  --用户头像
);
insert into Account values(1924295926,'tmj20000509','C:\Users\Magic Book\Desktop\通讯录信息管理系统\picture\头像1.jpg')
insert into Account values(18011728719,'tmj20000509','C:\Users\Magic Book\Desktop\通讯录信息管理系统\picture\头像1.jpg')

select * from Account

delete from Account where Account_Username = 18011728719 and Account_Password= 'tmj20000509'
--联系人表
create table Contact
(
	Contact_ID bigint primary key,  --联系人账号
	Acount_Username bigint constraint NN_Contact_AID not null constraint FK_AC_username foreign key references Account(Account_Username),--用户账号
	Contact_Name varchar(20) not null,  --联系人名字
	GP_Name varchar(40) not null,  --联系人分组
	Contact_Phone bigint not null,  --联系人电话
	Contact_Sex varchar(8),  --联系人性别
	Contact_Birthday varchar(40),  --联系人生日
	Contact_QQ bigint,  --联系人QQ
	Contact_Address varchar(100),  --联系人地址
	Contact_Email varchar(40),  --联系人邮箱
	Contact_WorkAddress varchar(100)  --联系人工作地址
	
);
insert into Contact values(18011728719,1924295926,'童梦君','家人',18570764035,'男','2000.05.09','1924295926','湖南长沙','1924295926@qq.com','湖南长沙')
insert into Contact values(1924295926,18011728719,'童一','家人',18011728719,'男','2000.05.09','2729904221','湖南长沙','1924295926@qq.com','湖南长沙')
insert into Contact values(2729904221,1924295926,'谭景龙','同学',2729904221,'男','2000.04.06','2729904221','湖南长沙','2729904221@qq.com','湖南长沙')

select * from Contact


--创建联系人视图（管理模式）
go
create view Contact_View
as
select Contact_ID,Contact_Name,GP_Name,Contact_Phone,Contact_Sex,Contact_Birthday,Contact_QQ,Contact_Address,Contact_Email,Contact_WorkAddress
from Contact
go
select * from Contact_View

delete from Contact_View where Contact_ID =12312312

--创建分组视图（管理模式）
go
create view Group_View(分组名字,总人数)
as
select GP_Name,count(GP_Name)
from Contact_View
group by GP_Name
go

select * from Group_View

--创建电话视图（管理模式）
go
create view Phone_View
as
select Contact_Name,Contact_Phone,GP_Name
from Contact_View
go
select * from Phone_View


--创建联系人视图（用户模式）
go
create view ContactView1_View
as
select Acount_Username,Contact_ID,Contact_Name,GP_Name,Contact_Phone,Contact_Sex,Contact_Birthday,Contact_QQ,Contact_Address,Contact_Email,Contact_WorkAddress
from Contact
group by Acount_Username,Contact_ID,Contact_Name,GP_Name,Contact_Phone,Contact_Sex,Contact_Birthday,Contact_QQ,Contact_Address,Contact_Email,Contact_WorkAddress
go
select * from ContactView1_View where Acount_Username = 18011728719


--创建分组视图（用户模式）
go
create view Group_View1(账号,分组名字,总人数)
as
select  Acount_Username,GP_Name,count(GP_Name)
from Contact
group by Acount_Username,GP_Name
go
select * from Group_View1 where 账号 = 18011728719

--创建电话视图（用户模式）
go
create view Phone_View1
as
select Acount_username,Contact_Name,Contact_Phone,GP_Name
from Contact
go

select * from Phone_View1 where Acount_Username = 18011728719

--联系人账号查询函数
go
create function Check_Contact(@para bigint)
	returns table
	as
	return
		select *
		from Contact
		where Contact_ID=@para
go

select * from Check_Contact(1924295926)


--名字查询函数
go
create function Check_ContactName(@para char(20))
	returns table
	as
	return
		select *
		from Contact
		where Contact_Name=@para
go

select * from Check_ContactName('谭景龙')


--电话查询函数
go
create function Check_ContactPhone(@para bigint)
	returns table
	as
	return
		select *
		from Contact
		where Contact_Phone=@para
go


if exists(select * from sysobjects where name = 'insert_Account' and type = 'p')
	drop procedure insert_Account
go
create procedure insert_Account(@Account_Username bigint,@Account_Password varchar(50),@Account_Image varchar(100))
as
	insert into Account values(@Account_Username,@Account_Password,@Account_Image)
go

if exists(select * from sysobjects where name = 'insert_Contact' and type = 'p')
drop procedure insert_Contact
go
create procedure insert_Contact(@Contact_ID bigint,@Acount_Username bigint,@Contact_Name varchar(20),@GP_Name varchar(40),@Contact_Phone bigint,
		@Contact_Sex varchar(8),@Contact_Birthday varchar(40),@Contact_QQ bigint,@Contact_Address varchar(100),@Contact_Email varchar(40),
		@Contact_WorkAddress varchar(100))
as
	insert into Contact values(@Contact_ID,@Acount_Username,@Contact_Name,@GP_Name,@Contact_Phone,@Contact_Sex,@Contact_Birthday,@Contact_QQ,
	@Contact_Address,@Contact_Email,@Contact_WorkAddress)
go
