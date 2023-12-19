create database المصريه_للطيران

create table الموظفين (
id int primary key,
Name nvarchar (20) not null ,
Address nvarchar (50) ,
salare float default 0,
Age int check (Age between 25 and 60),
Phone varchar (11) unique);
insert into الموظفين 
values (1,'ali','mansora',15000,43,01023232134)
insert into الموظفين
values (2,'mansor','mansora',15000,44,01026589134)
insert into الموظفين
values (3,'Ibrahim','Caieo',5000,26,01023239934)
insert into الموظفين
values (4,'Hassan','Zagazig',15000,55,01023232166)
insert into الموظفين
values (5,'Kaled','Alex',12000,33,01047232134)
insert into الموظفين
values (6,'yousef','Elbehera',12000,26,01028721134)





create table فريق_الطائرين (
كود_الطائر int primary key,
الاسم nvarchar (20) not null ,
العنوان nvarchar (50) ,
الوظيفه nvarchar (20),
المرتب float default 0,
العمر int check (العمر between 25 and 60),
الهاتف varchar (11) unique);
insert into فريق_الطائرين 
values (1,'Mohamed','mansora','captain',15000,43,01023232134)
insert into فريق_الطائرين 
values (2,'Ahmed','mansora','assistant',10000,44,01026589134)
insert into فريق_الطائرين 
values (3,'Ibrahim','Caieo','captain',15000,26,01023239934)
insert into فريق_الطائرين 
values (4,'Hassan','Zagazig','assistant',10000,55,01023232166)
insert into فريق_الطائرين 
values (5,'Kaled','Alex','captain',15000,33,01047232134)
insert into فريق_الطائرين 
values (6,'salem','Elbehera','assistant',10000,26,01028721134)   



create table الحجز (
كود_العميل int not null ,
الاسم nvarchar (20) not null ,
درجه_الحجز nvarchar (50),
كود_الطائره int  primary key ,
السعر float  default 0);

insert into الحجز 
values (1,'’Mahmoud','one','1',2000)
insert into الحجز 
values (2,'Yasmin','one','2',1200)
insert into الحجز 
values (3,'Amr','two','3',3000)
insert into الحجز 
values (4,'Mohamed','two','4',5000)
insert into الحجز 
values (5,'Ahmed','three','5',1000)
insert into الحجز 
values (6,'Mena','three','6',12000)



create table الطائرات (
كود_الطائره int primary key not null,
اسم_الطائره nvarchar (50) ,
عدد_الكراسي nvarchar (50));
insert into الطائرات 
values (1,'cssc1','200')
insert into الطائرات 
values (2,'cssc2','300')
insert into الطائرات 
values (3,'cssc3','200')
insert into الطائرات 
values (4,'cssc4','400')
insert into الطائرات 
values (5,'cssc5','100')
insert into الطائرات 
values (6,'cssc6','300')
   



   select *from الحجز

   select السعر , count as عدد ,sum (السعر) as الاجمالي 
   from الحجز  
   group by السعر 
   order by السعر desc;

   select السعر , count as عدد ,sum (السعر) as الاجمالي 
   from الحجز  
   group by السعر 
   having count (كود_العميل)>2
      order by السعر;

	  select * from الموظفين where address like 'g%';
	   select * from فريق_الطائرين where العنوان like '%t';
	    select * from الموظفين where name like 'a%';
 select * from الموظفين where Phone is null ;
  select * from فريق_الطائرين where الهاتف is not null ;

  select *
  from فريق_الطائرين 
  order by العمر asc

  alter table فريق_الطائرين add الحوافز nvarchar (50);