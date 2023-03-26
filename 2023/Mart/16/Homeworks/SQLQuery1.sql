use AdventureWorks2017

--Store adlı table'dan bütün column'ları select edin.
select * from Sales.Store

--Product adlı table'dan bütün column'ları select edin.
select * from Production.Product

--ProductCategory adlı table'dan sadəcə ProductCategoryID və Name column'larını select edin.
select ProductCategoryID, Name from Production.ProductCategory

--AddressType adlı table'dan sadəcə AddressTypeID və Name column'larını select edin.
select AddressTypeID, Name from Person.AddressType

--Document adlı table'dan sadəcə Title, FileName, ChangeNumber və Status column'larını select edin.
select Title, FileName, ChangeNumber, Status from Production.Document

/*Araşdırıb və ya düşünüb yaza biləcəyiniz bonus sorğu (yaza bilməsəniz eybi yox):
Store table'ından bütün məlumatları * ilə çəkin. Sadəcə ilk column SalesPersonID olsun.
Bu sorğuda SalesPersonID iki dəfə çıxsa da olar eybi yox.
*/
select SalesPersonID, * from Sales.Store