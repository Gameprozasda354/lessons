--Yeni database yaratmaq
--create database School

--Database'i silmek
--drop database School

--Students adinda table yaratmaq
create table Students
(
	Id int,
	Name nvarchar(100),
	Surname nvarchar(100)
)

--Table'i silmek
drop table Students;

--Movcud table'a deyisiklik etmek
alter table Students
add CreateDate datetime

alter table Students
add TestColumn datetime

--Movcud table'dan column silmek
alter table Students
drop column TestColum





--Restrictions
--Not Null
create table Persons
(
	Id int,
	Name nvarchar(100),
	Surname nvarchar(100)
)

create table PersonsWithNotNull
(
	Id int not null,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
)


--Unique
create table NotConstraintUniqueTest
(
	Id int not null, --Id tekrarlana biler
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Email nvarchar(255) not null --Email tekrarlana biler
)

create table ConstraintUniqueTest
(
	Id int not null unique, --Id tekrarlana bilmez
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Email nvarchar(255) not null unique --Email tekrarlana bilmez
)


--Primary Key
create table Employee
(
	Id int not null unique, --Id null ola ve ya tekrarlana bilmez
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
)

create table EmployeePKey
(
	Id int primary key, --Id null ola ve ya tekrarlana bilmez
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
)

--Check
create table EmployeeConstraintCheck
(
	Id int primary key,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Age int not null check(Age >= 18)
)

create table StudentsConstraintCheck
(
	Id int primary key,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Age int not null check(Age <= 35)
)


--Default
select getdate();

create table ConstraintDefault
(
	Id int primary key,
	Name nvarchar(100) not null default 'Ad daxil edilmeyib',
	Surname nvarchar(100) not null,
	Age int not null default 18 check(Age <= 35),
	CreateDate datetime default getdate()
)








--Table relations

create table Customers
(
	Id int primary key,
	Name nvarchar(50) not null,
	Surname nvarchar(50) not null,
	DocumentNumber int not null,
	DocumentSerial nvarchar(2) not null
)

create table Addresses
(
	Id int primary key,
	FullAddress nvarchar(500) not null
)

drop table Customers
drop table Addresses

create table Customers
(
	Id int primary key,
	Name nvarchar(50) not null,
	Surname nvarchar(50) not null,
	DocumentNumber int not null,
	DocumentSerial nvarchar(2) not null
)

create table Addresses
(
	Id int primary key,
	FullAddress nvarchar(500) not null,
	CustomerId int,
	foreign key (CustomerId) references Customers(Id)
)




--Insert
--insert into table_name (col1, col2, col3) values ('', '', 100);
--insert into table_name values ('', '', 100);

--insert into Students (Id, Name, Surname, EmailAddress) values (1, 'Orkhan', 'Farajov', 'orkhan@gmail.com');
--select * from Students;



--Update
--update table_name set colName = 'new value'
--update table_name set colName = 'new value' where Id = 1

select * from Students;

update Students set Surname = 'Ferecov' where Id = 1

update Students set Surname = 'Ferecov', EmailAddress = 'orxan@gmail.com' where Id = 1

update Students set EmailAddress = 'samir@gmail.com' where Id = 4

update Students set EmailAddress = 'samir@gmail.com'




--Delete

--Table'dan butun row'lari silir
delete Students;

delete Students where Id = 2;
delete Students where Id > 5;
delete Students where Id >= 5;
delete Students where Name = '';

delete Students where Name = '' and Surname = '';
delete Students where Name = '' and Surname = '' or Id > 100;



/*
Task in Lesson 1
1. Teachers adında bir table yaradın. 5 column olsun.
2. Insert əmriylə 5 fərqli məlumat əlavə edin.
3. Məlumatları əlavə etdikdən sonra, məlumatları update edin. Update sorğularınızı müxtəlif yazın. Yəni bir sorğuda 1, digərində 2 column update olsun.
Bütün update sorğularında where istifadə edin (and or da olsun).
4. Table'dan müəyyən etdiyiniz şərtləri təmin edən dataları silin. Məsələn adı 'Ceyhun' olan datanı, Id'si 2 olan və s.
*/




--Stored Procedures
insert into Staffs
(Name, Surname, Email, CreateDate, EditDate, IsDeleted)
values
('Omer', 'Isgenderli', 'omer@gmail.com', getdate(), null, 0);

select * from Staffs;



create proc some_procedure_name
(
--Qebul edeceyi parametrler
@id int,
@name nvarchar(50)
)
as
begin
select 1;
end


create proc spAddNewStaff
(
@name nvarchar(50),
@surname nvarchar(50),
@email nvarchar(250)
)
as
begin
	insert into Staffs
	(Name, Surname, Email, CreateDate, EditDate, IsDeleted)
	values
	(@name, @surname, @email, getdate(), null, 0);
end


--Procedure'u ise salmaq
exec spAddNewStaff @name='Orkhan0', @surname='Farajov0', @email='orkhan0@gmail.com'


create proc GetStaffs
as
begin
	select * from Staffs;
end

exec GetStaffs;




--Edit and delete procedure
alter proc spAddNewStaff
(
@name nvarchar(50),
@surname nvarchar(50),
@email nvarchar(250)
)
as
begin
	insert into Staffs
	(Name, Surname, Email, CreateDate, EditDate, IsDeleted)
	values
	(@name, @surname, @email, getdate(), getdate(), 0);
end

exec spAddNewStaff @name='Orkhan1', @surname='Farajov1', @email='orkhan1@gmail.com'

exec GetStaffs;

--procedure'u silmek
drop proc spAddNewStaff;





--Encryption Stored Procedures
create proc spAddBook
(
@name nvarchar(50),
@author nvarchar(50),
@page int
)
with encryption
as
begin
	insert into Books
	(Name, Author, Page, CreateDate, EditDate, IsDeleted)
	values
	(@name, @author, @page, getdate(), null, 0);
end


--Optional Procedure Parameters
/*

--AdventureWorks2017 uzerinde tedbiq et!

create proc spGetEmployeesOptional
(
	@gender char(1) = 'M'
)
with encryption
as
begin
	select * from HumanResources.Employee where Gender = @gender;
end

exec spGetEmployeesOptional;
exec spGetEmployeesOptional @gender = 'F';
*/