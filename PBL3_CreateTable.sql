--create database PBL3
use PBL3
create table LHP
(
	IDLop int identity primary key,
	TenLop char(50),
	Tiet char(10),
	Thu char(10),
)
create table SV
(
	MSSV char(9) primary key,
	Ten nvarchar(50),
	NgaySinh Date,
	SDT char(11),
	GioiTinh bit,
	IDTKB char(9) ,
	constraint maTKB unique(IDTKB)
)
create table TKBSV
(
	IDTKB char(9) foreign key(IDTKB) references SV,
	IDLop int foreign key (IDLop) references LHP,
)
create table GV
(
	MGV char(9) primary key,
	Ten nvarchar(50),
	SDT char(11),
	DiaChi char(50),
	IDTKB char(9),
)
create table TKBGV
(
	IDTKB char(9) foreign key(IDTKB) references GV,
	Tiet char(10),
	Thu char(10)
)