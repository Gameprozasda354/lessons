use AdventureWorks2017

--Homework 1:
--Inner, Left, Right və Full join mövzularını mükəmməl bir şəkildə araşdırın və hər biri üçün bir neçə dənə sorğular yazın.
select * from Person.PersonPhone PP INNER JOIN Person.PhoneNumberType PNT 
ON PP.PhoneNumberTypeID = PNT.PhoneNumberTypeID

select * from Person.Person PP LEFT JOIN Person.EmailAddress PE
ON PP.rowguid = PE.rowguid

select * from Person.Person PP RIGHT JOIN Person.BusinessEntity PB
ON PP.BusinessEntityID = PB.BusinessEntityID

select * from Production.Product PP LEFT JOIN  Production.ProductModel PM
ON PP.ProductModelID = PM.ProductModelID

select * from Production.Product PP FULL JOIN  Production.ProductModel PM
ON PP.ProductModelID = PM.ProductModelID

--Homework 2:
--Kod yazaraq aşağıdakı table'ı yaradın. Sonra, UI tərəfdə də eynisini edin sadəcə table adının sonuna UI yazın ki, eyni adda iki table olmaz.
--Həm kod, həm də UI tərəfdə bu iki table'ı yaratdıqdan sonra UI ilə yaratdığınızı silə bilərsiniz. Sadəcə məşğələ məqsədi daşıyır. Ancaq Personals
--lazım olacaq. Yaradandan sonra aşağıdakı text'i oxuyun...





create table Personals
(
	Id int IDENTITY NOT NULL PRIMARY KEY,
	Name nvarchar(50) NOT NULL,
	Surname nvarchar(50) NOT NULL,
	Email nvarchar(250) NOT NULL UNIQUE,
	Gender char,
	CreatedDate date Default GetDate() NOT NULL,
	Updateddate date,
	IsDeleted bit DEFAULT 0

)

--Personals:
--id rəqəm avtomatik artan deyer, boş buraxıla bilməz, təkrarlana bilməz (avtomatik artan dəyəri necə yazacağınızı araşdırın)
--name (50 simvollu mətn), boş buraxıla bilməz
--surname (50 simvollu mətn), boş buraxıla bilməz
--email (250 simvollu mətn), boş buraxıla bilməz, oxşarı/eynisi olmamalıdır
--gender (bunu araşdırın ki, 1 simvolu hansı tip datada saxlaya bilərsiniz? bit olmasın.)
--createdDate ,default olaraq indiki zamanı alsın, boş ola bilməz
--updatedDate boş ola bilər
--isDeleted boş olduğu halda false olsun

--Aşağıda yazdığım select sorğusu sizə AdventureWorks database'indən müəyyən datalar qaytaracaq. Sizin etməli olduğunuz, aşağıdakı sorğuda sizə gələn
--dataları, yuxarıda yaratdığınız Personals table'ınıza insert etməyinizdir. Ad, Soyad, Cinsiyyət select sorğusundan gəldiyi kimi daxil ediləcək. Email
--ünvanı isə, ad.soyad@gmail.com formatında olacaq. Məsələn orxan.ferecov@gmail.com.
--Aşağıdakı sorğuda sizə gələn ad və soyad ilə email generate edəcəksiniz. Ad və soyad böyük hərflə başlayır. Siz araşdırma edərək ad və soyad'dan email
--generate edən zaman ad və soyad'ı kiçik hərflərə çevirməyi tapmalısınız. yəni Orxan Ferecov üçün orxan.ferecov@gmail.com generate olunacaq. Bu taskı
--etmək üçün, internetdən araşdırma etməlisiniz. Bir select sorğusundan gələn nəticəni başqa table'a insert etməyi öyrənməlisiniz.

--select * from Person.Person as PP
--inner join HumanResources.Employee HRE on
--PP.BusinessEntityId = HRE.BusinessEntityId

Insert Into Personals(Name, Surname, Gender, Email )
select FirstName, LastName, Gender, Lower(FirstName) + '.' + Lower(LastName) + '@gmail.com' from Person.Person as PP
inner join HumanResources.Employee HRE on
PP.BusinessEntityId = HRE.BusinessEntityId

--Homework 3:
--Aşağıda yazdığım select sorğusunda hər iki table'dan column'lar gəlir. Siz elə etməlisiniz ki,
--BusinessEntityID column'u Id olaraq, Firstname column'u Name olaraq, LastName column'u Surname olaraq, əlavə Email column'u Firstname və Lastname'dən 
--istifadə edərək kiçik hərflə orkhan.farajov@gmail.com olaraq, Gender, əlavə Date column'unda indiki tarixi almalısınız.

--select * from Person.Person as PP
--inner join HumanResources.Employee HRE on
--PP.BusinessEntityId = HRE.BusinessEntityId

select PP.BusinessEntityID Id, FirstName Name, LastName SurName, Email = Lower(FirstName) + '.' + Lower(LastName) + '@gmail.com', 
Gender, ModifiedDate = GetDate() from Person.Person as PP
inner join HumanResources.Employee HRE on
PP.BusinessEntityId = HRE.BusinessEntityId

--Homework 4:
--Aşağıdakı procedure'ları yazacaqsınız.
--spAddPersonal (parametrləri alıb yeni data əlavə edəcək və prosedurda şifrələnmə istifadə ediləcək)
--spEditPersonal (parametrləri alıb Id'yə görə dataları editləyəcək)
--spRemovePersonal (Id'ə görə datanı siləcək)

--spGetAllPersonals (parametr almayan prosedur olacaq)
--spGetPersonalById (Id'ə görə 1 dənə personel qaytaracaq)
--spSearchPersonalByEmail (aldığı parametri Email column'u üzrə axtarıb nəticəni qaytaracaq)



CREATE PROCEDURE spAddPersonal

	(@Name nvarchar(50),
	@SurName nvarchar(50),
	@Email nvarchar(250),
	@Gender char)
with encryption
As
Begin
	Insert Into Personals(Name, Surname, Email, Gender)
	Values
		(@Name, @SurName, @Email, @Gender)
End
Go
 

CREATE PROCEDURE spRemovePersonal
	@Id int

As
Begin
	 Delete Personals  where Id = @Id
End
Go


 CREATE PROCEDURE spEditPersonal
	(@Id int,
	@Name nvarchar(50),
	@SurName nvarchar(50),
	@Email nvarchar(250),
	@Gender char)

As
Begin
	Update Personals set Name = @Name, Surname = @SurName, Email = @Email, Gender = @Gender where Id = @Id
End
Go

CREATE PROCEDURE spGetAllPersonals
	
As
Begin
	select * from Personals
End
Go



CREATE PROCEDURE spGetPersonalById
	@Id int
As
Begin
	select * from Personals where Id = @Id
End
Go



CREATE PROCEDURE spSearchPersonalByEmail
	@Email nvarchar(250)
As
Begin
	select * from Personals where Email  = @Email
End
Go
