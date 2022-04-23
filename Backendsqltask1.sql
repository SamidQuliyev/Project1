CREATE TABLE Employees( ID int identity primary key,Name nvarchar(50) not null,
Surname nvarchar(100),Salary int not null)
insert into Employees values ('Anar','Qurbanov',500),('Elmar','Babayev', 892),
('Aysel','Eliyeva',651),('Ferhad','Resulzade',725),('Leyla','İmanov',498),
('Saleh','İbrahimov',554)
create table TestBool(Text nvarchar(10),Result bit)
insert into TestBool values ('a',1),('b',0)
select Text,Result from TestBool  --Bool tipi
decimal --Kesrli ededleri yazmaq ucun  decimal(ededdeki max reqemlerin sayi,vergulden sonraki max reqemin sayi)
