use AdventureWorks2017

/*
VACİB QEYD: Taskların heç birini edərkən qətiyyən copy-paste etməyin. Bütün sorğuları bir-bir özünüz yazın.

Bütün taskları Adventure Works database'ində işləyəcəksiniz. Table seçimlərini sizə həvalə edirəm.
*/
--Homework 1:
--Ən az 10 fərqli table'dan məlumat select edin.
select * from Person.Address

select * from Person.PersonPhone

select * from Production.Location

select * from Production.ProductCostHistory

select * from HumanResources.Employee

select * from HumanResources.EmployeePayHistory

select * from Purchasing.PurchaseOrderHeader

select * from Sales.CreditCard

select * from Purchasing.ProductVendor

select * from Sales.CountryRegionCurrency

--Homework 2:
--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 1 column'a şərt qoyun.

select * from Person.PersonPhone where PhoneNumberTypeID != 3

select * from HumanResources.Employee where MaritalStatus = 'S'

select * from Production.Product where ReorderPoint > 375

select * from Sales.CreditCard where CardType = 'SuperiorCard'

select * from Purchasing.PurchaseOrderDetail where OrderQty = 550


--Homework 3:
--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 2 column'a şərt qoyun (and ilə).

select * from Sales.CurrencyRate where ToCurrencyCode = 'CAD' and AverageRate > 1

select * from Person.Person where FirstName = 'Michael' and MiddleName != 'L'

select * from Production.BillOfMaterials where BOMLevel > 0 and BillOfMaterialsID > 1000

select * from Production.WorkOrder where OrderQty > 15 and ScrappedQty != 0

select * from Person.BusinessEntityAddress where AddressTypeID != 2 and AddressID > 1000


--Homework 4:
--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 2 column'a şərt qoyun (or ilə).
	
select * from Person.Person where Title = 'Mr.' or LastName = 'Crow'

select * from Production.Document where FileExtension = '.doc' or Status = 2

select * from Production.WorkOrder where ScrappedQty = 0 or OrderQty > 40

select * from Sales.Store where SalesPersonID = 277 or Name like 'B%'

select * from Person.EmailAddress where EmailAddressID > 10 or EmailAddress like 'j%'

--Homework 5:
--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 4 column'a şərt qoyun (and ilə).

select * from Person.Address where StateProvinceID = 79 and City = 'Bothell' and
AddressID > 3 and PostalCode = 98011

select * from Person.Person where FirstName like 'A%' and LastName like 'B%' and
EmailPromotion = 2 and NameStyle = 0

select * from Production.Product where FinishedGoodsFlag = 0 and ProductID > 10 and
Name like 'B%' and Color != 'Black'

select * from Production.ProductPhoto where ProductPhotoID > 20 and LargePhoto like '0%' and
ThumbnailPhotoFileName like 'r%' and LargePhotoFileName like 'r%'

select * from Purchasing.PurchaseOrderDetail where StockedQty > 2 and ReceivedQty >= 3 and
UnitPrice > 50 and ReceivedQty >= 1 

--Homework 6:
--Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 4 column'a şərt qoyun (or ilə).

select * from Person.Person where Title = 'Ms.' or FirstName like 'K%' or EmailPromotion = 0 or 
PersonType != 'EM'

select * from Purchasing.PurchaseOrderHeader where Freight > 5 or TotalDue = 222.1492 or
EmployeeID = 253 or TaxAmt > 1100

select * from Sales.Customer where AccountNumber like 'A%' or TerritoryID > 1 or CustomerID != 20
or rowguid like '3F%'

select * from Production.Product where SafetyStockLevel = 500 or ListPrice = 0 or
DaysToManufacture = 1 or Name like 'A%'

select * from HumanResources.Employee where Gender = 'F' or JobTitle = 'Research and Development Manager' or
MaritalStatus = 'S' or VacationHours > 30

--Homework 7:
--Ən az 6 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 3-4 column'a şərt qoyun (and və or ilə).

select * from Person.Person where (NameStyle = 0 and LastName like 'E%') or
(EmailPromotion = 0 and FirstName = 'Ken')

select * from Sales.Customer where (TerritoryID > 1 and StoreID > 300) or CustomerID > 50

select * from Production.Product where (SafetyStockLevel = 1000 and Color != 'Black') or
(ListPrice > 1 and DaysToManufacture = 0)

select * from Purchasing.PurchaseOrderDetail where StockedQty = 3 or 
(LineTotal <= 1000 and OrderQty >= 2)

select * from Person.Address where PostalCode = 98011 or 
(City = 'Bothell' and StateProvinceID = 79)

select * from Sales.CurrencyRate where (AverageRate >= 1  and ToCurrencyCode = 'JPY') or
(ToCurrencyCode = 'EUR' and CurrencyRateID > 50)

--Homework 8:
--5 fərqli table'dan ilk 5, 10, 15, 20, 25 məlumatı çəkməyə çalışın. Birindən ilk 5, digərindən ilk 10 və s.

select top 5 * from Person.PersonPhone

select top 10 * from Production.BillOfMaterials

select top 15 * from HumanResources.Employee

select top 20 * from Sales.CreditCard

select top 25 * from Purchasing.PurchaseOrderHeader

--Homework 9:
--Sales.SalesOrderDetail table'dan CarrierTrackingNumber'ində 480 rəqəmi keçən, OrderQty'i 15 olmayanları gətirin.
	
select * from Sales.SalesOrderDetail where CarrierTrackingNumber like '%480%' and OrderQty != 15

--Homework 10:
--Sales.SalesOrderDetail table'dan UnitPrice'ı 250-dən böyük və ya bərabər olan amma 125 olmayan,
--ProductID'si 1-dən böyük və 1000-dən kiçik və ya bərabər olanları gətirin

select * from Sales.SalesOrderDetail where UnitPrice >= 250 and UnitPrice != 125 and
ProductID > 1 and ProductID <=1000

