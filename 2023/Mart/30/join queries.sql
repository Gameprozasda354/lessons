use AdventureWorks2017
/*
Customers (table)
Id
Name
Surname
Gender
BirthDate
Email
PhoneNumber

Customers (table)
Id
Name
Surname
Gender
BirthDate
Email
PhoneNumber1
PhoneNumber2
PhoneNumber3
PhoneNumber4
PhoneNumber5
PhoneNumber6
PhoneNumber7



Customers (table)
Id 54
Name Orxan
Surname Farajov
Gender 1
BirthDate 12.12.12

ContactTypes (table) (Numune data: 1. Phone, 2. Email, 3. Faks)
Id 1
Name Phone

Contacts (table)
Id 103
CustomerId 54
ContactTypeId 1
Value 055 581 08 72
*/

select * from Person.Person;
select * from Person.EmailAddress;




--Inner Join
select * from Person.Person
inner join Person.EmailAddress
on Person.BusinessEntityID = EmailAddress.EmailAddressID


select * from Person.Person pp
inner join Person.EmailAddress pea
on pp.BusinessEntityID = pea.EmailAddressID


select 
pp.BusinessEntityID,
pp.FirstName,
pp.MiddleName,
pp.LastName,
pea.EmailAddress
from Person.Person pp
inner join Person.EmailAddress pea
on pp.BusinessEntityID = pea.EmailAddressID



--Left Join

select * from Person.Person;
select * from Person.ContactType;

select * from Person.Person pp
left join Person.ContactType pct
on pp.BusinessEntityID = pct.ContactTypeID

select 
pp.BusinessEntityID,
pp.FirstName,
pp.MiddleName,
pp.LastName,
pct.*
from Person.Person pp
left join Person.ContactType pct
on pp.BusinessEntityID = pct.ContactTypeID
order by pp.BusinessEntityID asc




--Right Join
select * from Person.Person;
select * from Person.ContactType;

select * from Person.Person pp
right join Person.ContactType pct
on pp.BusinessEntityID = pct.ContactTypeID




--Sub query
select * from Person.Person;
select * from Person.EmailAddress;

--inner join ile
select
pp.FirstName,
pp.LastName,
pea.EmailAddress
from Person.Person pp
inner join Person.EmailAddress pea
on pp.BusinessEntityID = pea.EmailAddressID



--sub query
select
FirstName,
LastName,
(select EmailAddress from Person.EmailAddress where EmailAddressID = Person.BusinessEntityID) as Email
from Person.Person;