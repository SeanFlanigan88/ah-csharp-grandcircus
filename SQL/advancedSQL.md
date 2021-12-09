# Advanced SQL

## Questions

---

## Database Recap

#### Create Database

```SQL
CREATE DATABASE databasename;
```

#### Drop Database

```SQL
DROP DATABASE databasename;
```

#### Drop Database

```SQL
DROP DATABASE databasename;
```

---
## Table Recap + Advanced Topics

#### Create Table

```SQL
CREATE TABLE Persons (
    PersonID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255) 
);
```

#### Create Table

```SQL
ALTER TABLE Customers ADD Email varchar(255);
```

#### Create Table

```SQL
ALTER TABLE Customers DROP COLUMN Email;
```

#### Create Constraints

Review Different [Constraints](https://www.w3schools.com/Sql/sql_constraints.asp)

```SQL
CREATE TABLE Persons (
    ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int CHECK (Age>=18)
    City varchar(255) DEFAULT 'Detroit'
);
```

#### Foreign Key

```SQL
CREATE TABLE Orders (
    OrderID int NOT NULL PRIMARY KEY,
    OrderNumber int NOT NULL,
    PersonID int FOREIGN KEY REFERENCES Persons(PersonID)
);
```

```SQL
ALTER TABLE Orders
ADD FOREIGN KEY (PersonID) REFERENCES Persons(PersonID);
```

## Working With Dates

* [Date Format](https://www.w3schools.com/Sql/sql_dates.asp)
* [Microsoft T-SQL Date Functions](https://docs.microsoft.com/en-us/sql/t-sql/functions/date-and-time-data-types-and-functions-transact-sql?view=sql-server-ver15)