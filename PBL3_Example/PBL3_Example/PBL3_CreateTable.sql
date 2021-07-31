create database PBL3
use PBL3
GO
create table LHP
(
	IDLop int identity primary key,
	TenLop nvarchar(50),
	TietBD int check (TietBD>=1 and TietBD <=10),
	TietKT int check (TietKT>=1 and TietKT <=10),
	Thu nvarchar(10) check (Thu in('Thu Hai','Thu Ba','Thu Tu','Thu Nam','Thu Sau','Thu Bay','Chu Nhat')),
	kieu bit not null default 0 -- 0:Mon Hoc 1:Lich Hen 
)
create table SV
(
	MSSV nvarchar(9) primary key CHECK (MSSV LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') ,
	Ten nvarchar(50),
	NgaySinh Date,
	SDT nvarchar(11) CHECK (SDT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') ,
	GioiTinh bit,
--	IDTKB nvarchar(9) not null CHECK (IDTKB LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
--	constraint maTKBSV unique(IDTKB)
)
create table TKBSV
(
	IDTKB nvarchar(9),
	constraint MaSV
	foreign key (IDTKB) references SV(MSSV) 
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	IDLop int 
	constraint MaLopSV
	foreign key (IDLop) references LHP(IDLop) 
	ON DELETE CASCADE
	ON UPDATE CASCADE,
)
create table GV
(
	MGV nvarchar(9) primary key CHECK (MGV LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Ten nvarchar(50),
	SDT nvarchar(11) CHECK (SDT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') ,
	DiaChi nvarchar(50),
--	IDTKB nvarchar(9) not null CHECK (IDTKB LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
--	constraint maTKBGV unique(IDTKB)
)
create table TKBGV
(
	IDTKB nvarchar(9) 	
	constraint MaGV
	foreign key (IDTKB) references GV(MGV) 
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	IDLop int 	constraint MaLopGV
	foreign key (IDLop) references LHP(IDLop) 
	ON DELETE CASCADE
	ON UPDATE CASCADE,
)
create table QLTK
(
	UserName nvarchar(9) primary key CHECK (UserName LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	PassWord nvarchar(50) not null default 0,
	LoaiTK bit not null default 0 -- 1:GV 0:SV 
)