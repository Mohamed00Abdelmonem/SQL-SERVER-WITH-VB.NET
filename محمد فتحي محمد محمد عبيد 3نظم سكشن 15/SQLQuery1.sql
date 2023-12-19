create database شركه_مقاولات

create table الموظفين (
id int primary key,
Name nvarchar (20) not null ,
Address nvarchar (50) ,
salare float default 0);
insert into الموظفين 
values (1,'mohmoud','cairo',1500)
insert into الموظفين 
values (2,'khaled','cairo',1500)
insert into الموظفين 
values (3,'Ibrahim','Caieo',5000)
insert into الموظفين 
values (4,'Hassan','cairo',10000)


create table الفروع (
كود_الفرع int primary key not null ,
اسم_الفرع nvarchar (20) not null ,
المكان nvarchar (20));

insert into الفروع 
values (1,'mansora','elmansora')
insert into الفروع 
values (2,'mansora','elmansora')
insert into الفروع 
values (3,'mansora','elmansora')
insert into الفروع 
values (4,'cairo','elmansora')



create table الخدمات (
كود_الخدمه int not null,
نوع_الخدمه nvarchar (50) ,
سعر_الخدمه nvarchar (50));


insert into الخدمات 
values (1,'خشب',3000)
insert into الخدمات 
values (2,'حديد',5200)
insert into الخدمات 
values (3,'اسمنت',4500)
insert into الخدمات 
values (4,'عده',6500)


select *from الموظفين

   select salare , count as عدد ,sum (salare) as الاجمالي 
   from الموظفين  
   group by salare 
   order by salare desc;

   select address , count as عدد ,sum (salare) as الاجمالي 
   from الموظفين  
   group by salare 
   having count (id)>2
      order by address;

	  select * from الموظفين where address like 'g%';
	   select * from الموظفين where address like '%t';
	    select * from الموظفين where name like 'a%';
 select * from الموظفين where salare is null ;
  select * from الموظفين where salare is not null ;

  select *
  from الموظفين 
  order by id asc

  alter table عميل add العنوان nvarchar (50);