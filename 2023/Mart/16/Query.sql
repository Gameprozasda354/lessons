use AdventureWorks2017

--Select command
select * from Person.Address;

--This is single line comment

/*
This
is
multi
line
comment
*/

use AdventureWorks2017; --Hansi database istifade edilsin onu bildirir
--Select: Table'dan melumatlari ceken emr
--From: Haradan ve ya hansi qaynaqdan melumatlari gotureceyini bildirir

--Yazilis qaydasi: select column_adlari (ve ya) * from table_adi

select AddressID, AddressLine1, City, PostalCode, ModifiedDate from Person.Address;