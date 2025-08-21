
create database calendar_2019;

use calendar_2019;


create table usser(

U_ID int primary key,
U_Name varchar(100) not null,
U_Pass varchar(50) not null,
);


create table eventts( 

Eve_ID int primary key,
Eve_Title varchar(100) not null,
Eve_Description varchar(200),
Date_Start date not null,
Date_End date,
Time_Begin time not null,
Time_End time,
Eve_Venue varchar (100),
U_ID int 
);
select * from eventts

drop table eventss

create table meetingss(
M_ID int primary key,
Client_ID int not null unique,
Client_Name varchar(50) not null,
Client_contact int not null unique,
Client_email varchar(50) ,
Strt_date date not null,
End_date date not null,
time_begin time not null  ,
time_end time not null,
M_attendees varchar(150),
M_Summary varchar(150),
M_Venue varchar (100),
U_ID int not null
);

drop table meetingss

select * from meetingss

create table appoinmentss(
Ap_ID int primary key,
Client_ID int not null,
Client_Name varchar(50) not null,
Client_contact int not null unique,
Client_email varchar(50) ,
Date_Start date not null ,
Date_End date not null,
Time_begin date not null , 
Time_end time not null,
Ap_Description varchar(150),
Ap_Venue varchar (100),
U_ID int not null 
);

drop table appoinmentss
select * from appoinmentss


