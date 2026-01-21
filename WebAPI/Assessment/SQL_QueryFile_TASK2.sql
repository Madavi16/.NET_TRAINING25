
create database Northwind_Task2_DB

create table Employees
(
EmployeeID int Primary key,
FirstName varchar(50),
LastName varchar(50)
)

Insert into Employees Values
(1,'Madhavi','Ravi'),
(2,'Virat','Kholi'),
(3,'Sai','Pallavi'),
(4,'Rithivik','Singh'),
(5,'Steven','Buchanan')

Create table Customers
(
CustomerID varchar(5) primary key,
CompanyName varchar(100),
Country varchar(50)
)

insert into Customers Values
('CU001', 'Tech Solutions Pvt Ltd', 'India'),
('CU002', 'Global Traders Inc', 'germany'),
('CU003', 'Sunrise Foods', 'France'),
('CU004', 'EuroMart GmbH', 'Germany'),
('CU005', 'Nippon Electronics', 'Sweden')

Create table Orders
(
OrderID int primary key,
CustomerID varchar(5),
EmployeeID int,
OrderDate Datetime,
Foreign Key (CustomerID) references Customers(CustomerID),
Foreign Key (EmployeeID) references Employees(EmployeeID)
)

insert into Orders Values
(10248, 'CU002',5,'2024-07-04'),
(10249,'CU001',5,'2025-07-05'),
(10250,'CU003',5,'2023-07-08'),
(10251,'CU004',3,'2024-07-09'),
(10252,'CU005',2,'2024-07-10')

Create procedure GetCustomersByCountry
@Country varchar(50)
as
begin
select CustomerID,CompanyName,Country
from Customers
where Country=@Country;
end


