create table Departments
( DepartmentId    int primary key,
  DepartmentName  varchar(20)  not null
)


create table Employees
(
  EmployeeId      int primary key,
  EmployeeName    varchar(20) not null,
  Salary		  int not null,
  Designation     varchar(30),
  JoinedOn		  DateTime default GetDate()  not null ,
  DepartmentId    int references Departments(DepartmentId)
)

insert into Departments values(10,'Sales');
insert into Departments values(20,'IT');
insert into Departments values(30,'Accounts');
insert into Departments values(40,'Production');


insert into Employees values(101,'Scott Guithrie',60000,'Programmer', '1/22/2017',20);
insert into Employees values(102,'Larry Ellison',40000,'Accountant', '3/1/2017',40);
insert into Employees values(103,'Mark Juke',80000,'Architect', '12/1/2016',20);
insert into Employees values(104,'Sergy Brin',70000,'Manager', '4/1/2017',10);




