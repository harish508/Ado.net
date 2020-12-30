alter procedure usp_Emp
	@Empid int
	--@Empname varchar(50),
	--@Emplocation varchar(50),
	--@Empphno varchar(50),
	--@Empsalary money
	--@Empgender varchar(50)

as
begin
	delete Employee where Empid=@Empid;
END


select * from Employee