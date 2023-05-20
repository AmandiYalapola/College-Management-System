create database college;

create table NewAdmission1(
NAID int NOT NULL  primary key,
fname varchar(250)  null,
mname varchar(250)  null,
gender varchar(10)  null,
dob varchar(50)  null,
mobile int  null,
email varchar(250) null ,
semester varchar(100)  null,
prog varchar(150)  null,
sname varchar(150)  null,
duration varchar(120)  null,
addres varchar(250)  null
)

fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres

select * from NewAdmission1
update NewAdmission1 set semester = '4th Sem' where semester = '2rd Sem';

select max(NAID) from NewAdmission1;

