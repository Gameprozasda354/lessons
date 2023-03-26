--IN - NOT IN

--OR ilə ProductNumber bərabər olanları götürmək
select * from Production.Product where
ProductNumber = 'AR-5381' or
ProductNumber = 'BA-8327' or
ProductNumber = 'BE-2349' or
ProductNumber = 'CA-5965' or
ProductNumber = 'CR-9981'

--IN ilə bərabər olanları götürmək
select * from Production.Product where
ProductNumber
IN
(
'AR-5381',
'BA-8327',
'BE-2349',
'CA-5965',
'CR-9981'
)

--AND ilə ProductNumber bərabər olmayanları götürmək
select * from Production.Product where
ProductNumber != 'AR-5381' and
ProductNumber != 'BA-8327' and
ProductNumber != 'BE-2349' and
ProductNumber != 'CA-5965' and
ProductNumber != 'CR-9981'

--NOT IN ilə bərabər olanları götürmək
select * from Production.Product where
ProductNumber
NOT IN
(
'AR-5381',
'BA-8327',
'BE-2349',
'CA-5965',
'CR-9981'
)





--Order By (sorting)
--asc = ascending
--desc = descending
select * from Production.ProductModel where Name like '%a%';
select * from Production.ProductModel where Name like '%a%' order by Name;

select * from Production.ProductModel where Name like '%a%' order by ProductModelID desc;
select * from Production.ProductModel where Name like '%a%' order by Name desc;


--Id'ə görə artan sıralama
select * from Sales.Store order by SalesPersonID asc
select * from Sales.Store order by SalesPersonID

--Id'ə görə azalan sıralama
select * from Sales.Store order by SalesPersonID desc

select * from Sales.Store order by Name asc
select * from Sales.Store order by Name
select * from Sales.Store order by Name desc

-- A-Z sıralama: asc
-- Z-A sıralama: desc



-- Group By (sorting)
select * from Production.Product;

select * from Production.Product where Color is not null

select Color, SUM(SafetyStockLevel) StockLevel, AVG(ListPrice) AvgPrice from Production.Product
where Color is not null
group by Color

select Color, SUM(SafetyStockLevel) StockLevel, AVG(ListPrice) AvgPrice from Production.Product
group by Color




/*
1. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların bütün column'larını gətir.
2. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların FirstName, MiddleName, LastName column'larını FullName adı olaraq gətir.
3. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların bütün column'larını gətir.
4. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların BusinessEntityID column'unun toplamını Total adı olaraq gətir.
5. Person.Address table'ından bütün dataları gətir. Ancaq PostalCode column'una görə A-dan Z'yə (artan) sırala.
6. Person.Address table'ından bütün dataları gətir. Ancaq City column'una görə Z-dən A'ya (azalan) sırala.
7. Person.Address table'ından City column'una görə qruplaşdıraraq neçə adres olduğunu çıxardın. Yəni hər şəhər üçün neçə adres məlumatı var? Eyni zamanda da şəhər sayına görə azalan sıralama edin.
*/

select * from Person.Person where FirstName in ('Scott', 'Frank', 'Eric'); --1
select FirstName + ' ' + MiddleName + ' ' + LastName Fullname from Person.Person where FirstName in ('Scott', 'Frank', 'Eric'); --2
select * from Person.Person where FirstName not in ('Eugene', 'Barry', 'Jack'); --3
select sum(BusinessEntityID) Total from Person.Person where FirstName not in ('Eugene', 'Barry', 'Jack'); --4
select * from Person.Address order by PostalCode asc --5
select * from Person.Address order by City desc --6

select City, count(AddressID) CountOfAddressPerCity from Person.Address 
group by City order by CountOfAddressPerCity desc --7

select * from Person.Address





--Distinct
select * from Production.Product;

select distinct Color from Production.Product;

select distinct Color, Name from Production.Product;

select * from Sales.SalesOrderDetail;
select distinct ProductID from Sales.SalesOrderDetail;

select * from Production.Product
where
ProductID in
(
	select distinct ProductID from Sales.SalesOrderDetail
)

select Color, sum(ListPrice) from Production.Product
where
ProductID in
(
	select distinct ProductID from Sales.SalesOrderDetail
)
group by Color




--Between
select * from Production.Product;

select * from Production.Product where ListPrice >= 50 and ListPrice <= 100;

select * from Production.Product where ListPrice between 50 and 100;