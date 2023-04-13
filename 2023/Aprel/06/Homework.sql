/*
Homework 1:
Ev tapşırığı olaraq custom function'lar yaratmağı öyrənib, kiçik bir calculator app'ı yazacaqsınız.
C#'da etdiyiniz calculator app'lar kimi hazırlaya bilərsiniz. Əsas məsələ custom function'larla
işləməkdir.
*/

CREATE FUNCTION Calculator(@firstNumber int = 0, @secondNumber int = 0, @operation nvarchar(10))
RETURNS int
AS
BEGIN
	DECLARE @answer int
    if (@operation = 'Addition')
		set @answer = (@firstNumber + @secondNumber)
	if (@operation = 'Substract')
		set @answer = (@firstNumber - @secondNumber)
	if (@operation = 'Multiple')
		set @answer = (@firstNumber * @secondNumber)
	if (@operation = 'Division')
		set @answer = (@firstNumber / @secondNumber)

	return @answer
END
GO

/*
Homework 2:
C#'da bildiyiniz bütün data tiplərin SQL'dəki qarşılığını tapın. Bir table yaradıb, C#'da bildiyiniz bütün data tiplərinin SQL'də
olan qarşılığından istifadə edərək praktika edin. İnsertlərini də yazın mütləq.
*/

drop table DataTypes

create table DataTypes
(
	Bool bit,
	Int16 smallint,
	Int32 int,
	Int64 bigint,
	String nvarchar(20),
	Decimal1 decimal,
	Float1 float,
	Char1 char,
	DateTime1 datetime

)

insert into DataTypes(Bool, Int16, Int32, Int64, String, Decimal1, Float1, Char1, DateTime1)
Values (0, 365, 6473576, 623652426546354, 'Baki', 6.243, 8.0975, 'H', GETDATE())


select * from DataTypes