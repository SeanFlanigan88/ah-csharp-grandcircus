--1. Create a database called CompanyDb

create database CompanyDb

--2. Construct a table called Department. Department has the following columns:
    -- Id- int PK auto-increment
    -- Name - nvarchar 25 NOT NULL
    -- Hiring - bit
    -- Location - nvarchar 50

create table Department(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(25) NOT NULL,
	Hiring bit,
	Location nvarchar(50)

);

--3. Add the two departments from above to the table.

insert into Department(Name, Hiring, Location)
values 
	('Technology', 1, '1570 Woodward Ave.'),
	('Shipping & Receiving', 0, 'Southfield')

--4. Construct a table named Employee. Employee has the following columns.
    -- SSN - nchar 9 PK
    -- DOB - DATE
    -- Phone - nchar 10
    -- FirstName - nvarchar 30 NOT NULL
    -- LastName - nvarchar 30 NOT NULL
    -- DepartmentId- This is a foreign key reference to Departments. Choose the appropriate data type. (Note this is a many-to-one relationship: many employees to one department.)

create table Employee(
	SSN nchar(9) PRIMARY KEY,
	DOB date,
	Phone nchar(10),
	FirstName nvarchar(30) Not Null,
	LastName nvarchar(30) Not Null,
	DepartmentId int foreign key references Department(Id)
);

--5. Add the 4 employees from above to the table.

insert into Employee(SSN, DOB, Phone, FirstName, LastName, DepartmentId)
values 
	('123456789', '1975-5-1', '3135555505', 'Charles', 'Charleston', 2),
	('987654321', '1990-2-5', '2489995555', 'Jimmy', 'Scrambles', 1),
	('456789123', '2001-6-8', '7895555525', 'Vince', 'Jabowski', 1),
	('654854632', '1988-6-4', '3139721400', 'John', 'Johnston', 2)

--6. Update the youngest employee to have a LastName of “Spiderman”.

update Employee Set LastName='Spiderman' where DOB = (
	select max(DOB) from Employee
);

--7. Select all employees with the LastName that starts with “J”.

Select * from Employee where LastName Like 'J%'

--8. Remove the oldest employee.

delete from Employee where DOB = (
	select min(DOB) from Employee-
);

--9. Select all employees with a 313 area code.

Select * from Employee where Phone Like '313%'

--10. Select all employees that have a DOB before 9/9/1999.

Select * from Employee where DOB < '1991-9-9'

--11. Update the employees with DOB after 2000 to have no phone number.

update Employee Set Phone=null where DOB > '2000-1-1'

--12. Select all employees that do not have a phone number.

select * from Employee where Phone is null

--13. Use one statement to list all employees along with the name and location of the department the employee belongs to.

select * from Employee join Department on Employee.DepartmentId = Department.Id

--14. Delete both tables and all their contents from the database.

drop table if exists Employee
drop table if exists Department 
