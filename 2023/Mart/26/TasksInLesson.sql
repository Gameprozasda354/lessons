﻿use AdventureWorks2017

select FirstName + ' ' + MiddleName + ' ' + LastName [FullName], BusinessEntityID + '-' + EmailPromotion [Sira nomresi] from person.Person

/*
1. Person.EmailAddress table'ından EmailAddressID'si 3 olan məlumatların bütün column'larını gətir.
*/

select * from Person.EmailAddress where EmailAddressID = 3;

select * from Production.ProductDocument where ProductID = 517;

select * from Sales.Currency where CurrencyCode = 'AZM';

select Name , CountryRegionCode from Sales.SalesTerritory where TerritoryID = 6;

/*
1. Production.Product table'ından ProductID'si 20-dən böyük olan məlumatların bütün column'larını gətir.
*/

select * from Production.Product where ProductID > 20; --1
select * from Production.Product where ProductID < 20; --2
select ProductID, Name,  ListPrice from Production.Product where ListPrice > 200 and ListPrice < 500; --3
select * from Production.Product where SafetyStockLevel > 900 and ListPrice < 1500 and ProductID != 10; --4
select top 50 * from Production.Product where ProductNumber != 'BA-8327' and Color = 'Black'; --5
select top 50 percent * from Production.Product where ListPrice <= 500; --6
select top 25 percent * from Production.Product where ListPrice >= 1001; --7
select * from Production.Product where Color = 'Black' or Color = 'Red'; --8
select ProductID from Production.Product where ProductID > 100 and ProductID < 500 and ProductID != 300; --9
select ProductID from Production.Product where (SafetyStockLevel = 800 or SafetyStockLevel = 1000) and (Color != 'Black' or Color != 'Blue') ; --10
select City + ',' + PostalCode + ',' + AddressLine1 [FullAddress] from Person.Address ; --11


/*
1. Person.PersonPhone table'ından PhoneNumber column'unda 15 rəqəmi olan məlumatların bütün column'larını gətir.
*/


select * from Person.PersonPhone where PhoneNumber like '%15%';--1
select * from Person.PersonPhone where PhoneNumber like '1%';--2
select * from Person.PersonPhone where PhoneNumber like '%15';--3
select * from Person.PersonPhone where PhoneNumber like '%82%';--4
select * from Person.ContactType where Name like '%a%';--5
select * from Person.ContactType where Name like 'r%';--6
select * from Person.ContactType where Name like '%s';--7
select * from person.Person where FirstName like 'o%a';--8
select * from person.Person where FirstName like 'o%a' and LastName like '%ver%';--9
select top 40 * from person.Person where FirstName like '%a' and PersonType != 'ZT' ;--9

/*
1. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların bütün column'larını gətir.
Yəni hər şəhər üçün neçə adres məlumatı var? Eyni zamanda da şəhər sayına görə azalan sıralama edin.
*/

select * from Person.Person where FirstName IN ('Scott', 'Frank', 'Eric') --1
select FirstName + ' ' + MiddleName + ' ' + LastName [FullName] from Person.Person where FirstName IN ('Scott', 'Frank', 'Eric') --2
select * from Person.Person where FirstName NOT IN ('Eugene', 'Barry', 'Jack') --3
select SUM(BusinessEntityID) Total from Person.Person where FirstName NOT IN ('Eugene', 'Barry', 'Jack') --4
select * from Person.Address  Order By PostalCode --5
select * from Person.Address Order By City desc --6
select * from Person.Address Order By City desc --7