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

create table DataTypes
(
	Bool nvarchar(20),
	Int16 nvarchar(20),
	Int32 nvarchar(20),
	Int64 nvarchar(20),
	String nvarchar(20),
	Decimal1 nvarchar(20),
	Float1 nvarchar(20),
	Char1 nvarchar(20),
	DateTime1 nvarchar(20)

)

insert into DataTypes(Bool, Int16, Int32, Int64, String, Decimal1, Float1, Char1, DateTime1)
Values ('bit', 'smallint', 'int', 'bigint', 'nvarchar', 'decimal', 'float', 'char', 'datetime')


