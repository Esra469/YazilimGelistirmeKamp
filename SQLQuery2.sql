--Select
Select ContactName,CompanyName,City from Customers

select * from Customers where City='London'

--case instensiev(büyük küçük harf duyarsız)
select * from Products where CategoryID=1 or CategoryID=3

--Neye göre sıralanacağını order by ile düzenleriz.
select * from Products order by ProductName 
--fiyata göre sırala
select * from Products order by UnitPrice asc --asc azalandan artana descending (düşen), ascending(artan)

select* from Products where CategoryID=1 order by UnitPrice desc

select COUNT(*) from Products --toplam kaç tane product var 

select COUNT(*) from Products where CategoryID=2 --kategori ıd si 2 olan toplam kişiler

--Hangi kategoride kaç farklı ürünümüz var

select CategoryID,COUNT(*) from  Products group by CategoryID --her kategoriId de kaç tane var

--ürün sayısı 10 dan az olanları al (group by larda koşul having olarak yazılır)
select CategoryID,COUNT(*) from Products group by CategoryID having	count(*) <10

select CategoryID,COUNT(*) from Products where UnitPrice>20
group by CategoryID having	count(*) <10


--istediğimiz alanlardaki product ve categories yan yana getir ve ıdleri aynıysa göster
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products Inner Join Categories
on Products.CategoryID=Categories.CategoryID

--DTO Data Transformation object 
--Inner join iki tabloda da eşleşiyorsa getirir
select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID

--solda olup sağda olmayanları da getir
select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID

--muşteri olup siparişleri olmayanlar
select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerID is null --hiç ürün almamış kişiler

