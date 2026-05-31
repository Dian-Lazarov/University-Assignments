create database HR_Management;
use HR_Management;
drop database HR_Management;

create table tblDepartments (
DepID integer,
DepName varchar(150) default 'None' not null,
DepLocation varchar(100),
DepBudget decimal(10,2),
constraint PK_Department primary key(DepID)
);

create table tblPositions (
PosID integer,
PosTitle varchar(150) not null,
PosSalary decimal(10,2),
DepID integer,
constraint PK_Position primary key(PosID),
constraint FK_Position foreign key(DepID) references tblDepartments(DepID)
);

create table tblEmployees (
EmpID integer,
EmpFirstName varchar(75) not null,
EmpLastName varchar(75) not null,
EmpEmail varchar(255) unique,
EmpPhone varchar(20),
EmpAddress varchar(255),
EmpHireDate date not null,
PosID integer,
DepID integer,
constraint PK_Employee primary key(EmpID),
constraint FK1_Employee foreign key(PosID) references tblPositions(PosID),
constraint FK2_Employee foreign key(DepID) references tblDepartments(DepID)
);

create table tblEmployeeDetails (
EmpID integer primary key,
FullName varchar(150) not null,
Department varchar(150),
Location varchar(100),
Position varchar(150) not null,
Salary decimal(10,2),
constraint FK_EmployeeDetails foreign key(EmpID) references tblEmployees(EmpID)
	on delete cascade
	on update cascade
);

select * from tblDepartments;
drop table tblDepartments;
truncate table tblDepartments;

select * from tblPositions;
drop table tblPositions;
truncate table tblPositions;

select * from tblEmployees;
drop table tblEmployees;
truncate table tblEmployees;

select * from tblEmployeeDetails;
drop table tblEmployeeDetails;
truncate table tblEmployeeDetails;