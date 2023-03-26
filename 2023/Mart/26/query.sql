--Renaming columns while selecting datas from tables
select * from person.Person;

select BusinessEntityID, FirstName, MiddleName, LastName from person.Person;

--Column'ları birləşdirmək, yenidən adlandırmaq

--Column'un adı (No column name olaraq çıxacaq)
select BusinessEntityID, FirstName + ' ' + MiddleName + ' ' + LastName from person.Person;

--Column adlarını dəyişmək (table'da dəyişmir sadəcə select edən zaman yeni adla göstərir)
select BusinessEntityID Sira, Firstname Ad, LastName Soyad from person.Person;

select BusinessEntityID, FirstName + ' ' + MiddleName + ' ' + LastName Fullname from person.Person;

select BusinessEntityID, FirstName + ' ' + LastName [Ad Soyad] from person.Person;

select FirstName + ' ' + MiddleName + ' ' + LastName [FullName], BusinessEntityID + '-' + EmailPromotion [Sira nomresi] from person.Person




--Top Clause
select * from Person.Address;

--Table'dakı ilk 20 datanı gətir
select top 20 * from Person.Address;

--Table'dakı ilk 20% datanı gətir
select top 20 percent * from person.Address;
select top 30 percent * from person.Address;



--Where Clause
select * from person.Person;

--Adı John olan bütün person'ları gətir
select * from person.Person where FirstName = 'John';

--ID'si 9 olan Person'ları gətir
select * from Person.Person where BusinessEntityID = 9;

--EmailPromotion'u 2 olan Person'ları gətir
select * from Person.Person where EmailPromotion = 2

/*
1. Person.EmailAddress table'ından EmailAddressID'si 3 olan məlumatların bütün column'larını gətir.
2. Production.ProductDocument table'ından ProductID'si 517 olan məlumatların bütün column'larını gətir.
3. Sales.Currency table'ından CurrencyCode'u 'AZM' olan məlumatların bütün column'larını gətir.
4. Sales.SalesTerritory table'ından TerritoryID'si 6 olan məlumatların sadəcə Name və CountryRegionCode 
column'larını gətir.
*/
select * from Person.EmailAddress where EmailAddressID=3; --1
select * from Production.ProductDocument where ProductID=517; --2
select * from Sales.Currency where CurrencyCode='AZM'; --3
select Name, CountryRegionCode from Sales.SalesTerritory where TerritoryID=6; --4

select [Group], CountryRegionCode from Sales.SalesTerritory where TerritoryID=6;


--Multiple where clause
--and (and operatorundakı bütün şərtlər təmin edilməlidir)
select * from person.Person where FirstName = 'John' and LastName = 'Berry';
select * from person.Person where PersonType = 'EM' and BusinessEntityID = 3;

--or
select * from person.Person where FirstName = 'John' or FirstName = 'Rob';
select * from person.Person where FirstName = 'Orkhan' or FirstName = 'Rob';

--and - or
select * from person.Person where FirstName = 'John' or FirstName = 'Rob' and PersonType = 'IN';



--Comparsion Operators
select * from Production.Product

-- > (böyükdür)
select * from Production.Product where ListPrice > 500;
select * from Production.Product where ListPrice > 350;

-- < (kiçikdir)
select * from Production.Product where ListPrice < 600;
select * from Production.Product where ListPrice < 50;

-- >= (böyükdür bərabərdir)
select * from Production.Product where ListPrice >= 750;
select * from Production.Product where ListPrice >= 1000;

-- <= (kiçikdir bərabərdir)
select * from Production.Product where ListPrice <= 750;
select * from Production.Product where ListPrice <= 1000;

-- = (bərabərdir)
select * from Production.Product where Color = 'Black';
select * from Production.Product where Color = 'Yellow';

-- != (bərabər deyilsə)
select * from Production.Product where Color != 'Black';
select * from Production.Product where Color != 'Yellow';


/*
1. Production.Product table'ından ProductID'si 20-dən böyük olan məlumatların bütün column'larını gətir.
2. Production.Product table'ından ProductID'si 20-dən kiçik olan məlumatların bütün column'larını gətir.
3. Production.Product table'ından ListPrice'ı 200-dən böyük, 500-dən kiçik olan məlumatların ProductID, Name və ListPrice column'larını gətir.
4. Production.Product table'ından SafetyStockLevel'i 900-dən böyük, 1500-dən kiçik olan və ProductID'si 10 olmayan məlumatların bütün column'larını gətir.
5. Production.Product table'ından ProductNumber'ı 'BA-8327' olmayan, Color'u 'Black' olan ilk 50 dənə məlumatın bütün column'larını gətir.
6. Production.Product table'ından ListPrice'ı 500-dən kiçik və ya bərabər olan məlumatların 50%'ni gətir.
7. Production.Product table'ından ListPrice'ı 1001-dən böyük və ya bərabər olan məlumatların 25%'ni gətir.
8. Production.Product table'ından Color'u 'Black' və ya 'Red' olan, Color'u 'Yellow' olmayan məlumatların bütün column'larını gətir.
9. Production.Product table'ından ProductID'si 100-dən böyük, 500-dən kiçik olan və 300, 500 olmayan məlumatların ProductID column'unu gətir.
10. Production.Product table'ından SafetyStockLevel'i 800 və ya 1000 olan amma Color'u 'Black' və ya 'Blue' olmayan məlumatların bütün column'larını gətir.
11. Person.Address table'ından City, PostalCode və AddressLine1 column'larının dəyərlərini aralarında vergül olmaqla FullAddress column adı ilə çəkin.
*/

select * from Production.Product where ProductID > 20; --1
select * from Production.Product where ProductID < 20; --2
select ProductID, Name, ListPrice from Production.Product where ListPrice > 200 and ListPrice < 500 --3
select * from Production.Product where SafetyStockLevel > 900 and SafetyStockLevel < 1500 and ProductID != 10 --4
select top 50 * from Production.Product where ProductNumber != 'BA-8327' and Color = 'Black'; --5
select top 50 percent * from Production.Product where ListPrice <= 500; --6
select top 25 percent * from Production.Product where ListPrice >= 1001; --7
select * from Production.Product where (Color = 'Black' or Color = 'Yellow') and Color != 'Yellow'; --8
select ProductID from Production.Product where ProductID > 100 and ProductID < 500 and ProductID != 300 and ProductID != 500; --9
select * from Production.Product where (SafetyStockLevel = 800 or SafetyStockLevel = 1000) and (Color != 'Black' or Color != 'Blue') --10
select City + ', ' + PostalCode + ', ' + AddressLine1 FullAddress from Person.Address





--Like operator

--a hərfilə başlayan
--like 'a%'

--b hərfilə bitən
--like '%b'

--içində t hərfi olan
--like '%t%'

--a hərfilə başlayan
select * from Person.Person where FirstName like 'a%'

--b hərfilə bitən
select * from Person.Person where FirstName like '%b'

--içində t hərfi olan
select * from Person.Person where FirstName like '%t%'

--al hərflərilə bitən
select * from Person.Person where FirstName like '%al'

--içində 'son' sözü olan
select * from Person.Person where FirstName like '%son%'


/*
1. Person.PersonPhone table'ından PhoneNumber column'unda 15 rəqəmi olan məlumatların bütün column'larını gətir.2. Person.PersonPhone table'ından PhoneNumber'i 1 rəqəmilə başlayan məlumatların bütün column'larını gətir.3. Person.PersonPhone table'ından PhoneNumber'i 15 rəqəmilə bitən məlumatların bütün column'larını gətir.4. Person.PersonPhone table'ından PhoneNumber column'unda 82 rəqəmi olan məlumatların bütün column'larını gətir.5. Person.ContactType table'ından Name column'unda a hərfi olan məlumatların bütün column'larını gətir.6. Person.ContactType table'ından Name'i r hərfilə başlayan məlumatların bütün column'larını gətir.7. Person.ContactType table'ından Name'i s hərfilə bitən məlumatların bütün column'larını gətir.8. Person.Person table'ından FirstName'i a hərfilə bitən və o hərfilə başlayan məlumatların bütün column'larını gətir.9. Person.Person table'ından FirstName'i a hərfilə bitən və o hərfilə başlayan və LastName'ında 'ver' sözü olan məlumatların bütün column'larını gətir.10. Person.Person table'ından FirstName'i a hərfilə bitən və PersonType'ı ZT olmayan ilk 40 məlumatın bütün column'larını gətir.
*/

select * from Person.PersonPhone where PhoneNumber like '%15%' --1
select * from Person.PersonPhone where PhoneNumber like '1%' --2
select * from Person.PersonPhone where PhoneNumber like '%15' --3
select * from Person.PersonPhone where PhoneNumber like '%82%' --4
select * from Person.ContactType where Name like '%a%' --5
select * from Person.ContactType where Name like 'r%' --6
select * from Person.ContactType where Name like '%s' --7
select * from Person.Person where FirstName like '%a' and LastName like 'o%' --8
select * from Person.Person where FirstName like '%a' and LastName like 'o%' and LastName like '%ver%' --9
select top 40 * from Person.Person where FirstName like '%a' and PersonType != 'ZT' --10