create database QLKhachSan

use QLKhachSan

create table Phong
(
MaK varchar(10),
TenK nvarchar(25),
SDT int,
TenP nvarchar(25),
NgayNhan date,
NgayTra date,
Dongia money
)

insert into Phong
values
('K01',N'Minh Đức',012345678,N'HSSV','07/08/2019','07/08/2020',150.000),
('K02',N'Hồng Hạnh',0964103866,N'QLKTX','12/05/2021','12/10/2021',180.000),
('K03',N'Tùng Lâm',0967730814,N'CSKH','01/01/2021','02/02/2021',230.000),
('K04',N'Mai Huyền',0123456789,N'QLNV','08/12/2020','10/16/2021',550.000),
('K05',N'Huy Hoàng',0123456789,N'QLTC','02/10/2018','02/20/2021',950.000)
