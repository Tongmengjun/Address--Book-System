create database Phone_Book
on primary
(                                  --���ļ�
	name = 'Phone_Book_data1',
	filename = 'D:\ͯ�ξ�\���ݿ����\ͨѶ¼����ϵͳ\Phone_Book_data1.mdf',
	size = 10MB,
	maxsize = 50MB,
	filegrowth = 1 MB
),
(								   --�����ļ�
	name = 'Phone_Book_data2',
	filename = 'D:\ͯ�ξ�\���ݿ����\ͨѶ¼����ϵͳ\Phone_Book_data2.ndf',
	size = 10MB,
	maxsize = 50MB,
	filegrowth = 1 MB
)
log on
(									--��־�ļ�
	name = 'Phone_Book_log',
	filename = 'D:\ͯ�ξ�\���ݿ����\ͨѶ¼����ϵͳ\Phone_Book_log.ldf',
	size = 10MB,
	maxsize = 50MB,
	filegrowth = 1 MB
)
--�û���
create table Account
(
	Account_Username bigint primary key,  --�û��˺�
	Account_Password varchar(50) not null,  --�û�����
	Account_Image varchar(100)  --�û�ͷ��
);
insert into Account values(1924295926,'tmj20000509','C:\Users\Magic Book\Desktop\ͨѶ¼��Ϣ����ϵͳ\picture\ͷ��1.jpg')
insert into Account values(18011728719,'tmj20000509','C:\Users\Magic Book\Desktop\ͨѶ¼��Ϣ����ϵͳ\picture\ͷ��1.jpg')

select * from Account

delete from Account where Account_Username = 18011728719 and Account_Password= 'tmj20000509'
--��ϵ�˱�
create table Contact
(
	Contact_ID bigint primary key,  --��ϵ���˺�
	Acount_Username bigint constraint NN_Contact_AID not null constraint FK_AC_username foreign key references Account(Account_Username),--�û��˺�
	Contact_Name varchar(20) not null,  --��ϵ������
	GP_Name varchar(40) not null,  --��ϵ�˷���
	Contact_Phone bigint not null,  --��ϵ�˵绰
	Contact_Sex varchar(8),  --��ϵ���Ա�
	Contact_Birthday varchar(40),  --��ϵ������
	Contact_QQ bigint,  --��ϵ��QQ
	Contact_Address varchar(100),  --��ϵ�˵�ַ
	Contact_Email varchar(40),  --��ϵ������
	Contact_WorkAddress varchar(100)  --��ϵ�˹�����ַ
	
);
insert into Contact values(18011728719,1924295926,'ͯ�ξ�','����',18570764035,'��','2000.05.09','1924295926','���ϳ�ɳ','1924295926@qq.com','���ϳ�ɳ')
insert into Contact values(1924295926,18011728719,'ͯһ','����',18011728719,'��','2000.05.09','2729904221','���ϳ�ɳ','1924295926@qq.com','���ϳ�ɳ')
insert into Contact values(2729904221,1924295926,'̷����','ͬѧ',2729904221,'��','2000.04.06','2729904221','���ϳ�ɳ','2729904221@qq.com','���ϳ�ɳ')

select * from Contact


--������ϵ����ͼ������ģʽ��
go
create view Contact_View
as
select Contact_ID,Contact_Name,GP_Name,Contact_Phone,Contact_Sex,Contact_Birthday,Contact_QQ,Contact_Address,Contact_Email,Contact_WorkAddress
from Contact
go
select * from Contact_View

delete from Contact_View where Contact_ID =12312312

--����������ͼ������ģʽ��
go
create view Group_View(��������,������)
as
select GP_Name,count(GP_Name)
from Contact_View
group by GP_Name
go

select * from Group_View

--�����绰��ͼ������ģʽ��
go
create view Phone_View
as
select Contact_Name,Contact_Phone,GP_Name
from Contact_View
go
select * from Phone_View


--������ϵ����ͼ���û�ģʽ��
go
create view ContactView1_View
as
select Acount_Username,Contact_ID,Contact_Name,GP_Name,Contact_Phone,Contact_Sex,Contact_Birthday,Contact_QQ,Contact_Address,Contact_Email,Contact_WorkAddress
from Contact
group by Acount_Username,Contact_ID,Contact_Name,GP_Name,Contact_Phone,Contact_Sex,Contact_Birthday,Contact_QQ,Contact_Address,Contact_Email,Contact_WorkAddress
go
select * from ContactView1_View where Acount_Username = 18011728719


--����������ͼ���û�ģʽ��
go
create view Group_View1(�˺�,��������,������)
as
select  Acount_Username,GP_Name,count(GP_Name)
from Contact
group by Acount_Username,GP_Name
go
select * from Group_View1 where �˺� = 18011728719

--�����绰��ͼ���û�ģʽ��
go
create view Phone_View1
as
select Acount_username,Contact_Name,Contact_Phone,GP_Name
from Contact
go

select * from Phone_View1 where Acount_Username = 18011728719

--��ϵ���˺Ų�ѯ����
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


--���ֲ�ѯ����
go
create function Check_ContactName(@para char(20))
	returns table
	as
	return
		select *
		from Contact
		where Contact_Name=@para
go

select * from Check_ContactName('̷����')


--�绰��ѯ����
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
