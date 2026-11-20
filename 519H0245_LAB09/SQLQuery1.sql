create database InternManage

create table Student
(
	STID varchar(10),
	SName nvarchar(50),
	Hometown nvarchar(50),
	DBO varchar(20),
	GPA float
)

insert into Student values ('IT001', N'Lê văn Tâm', N'Hà Nội', '20/10/2000', 9.5)
create table Taikhoan
(
	TenND varchar(30),
	Matkhau varchar(30),
	Quyen varchar(30)
)
insert into Taikhoan values ('IT001', '123', 'Student')
insert into Taikhoan values ('L001', '123', 'Admin')
