--Select
Select ContactName,CompanyName,City from Customers

Select * from Customers where City = 'London'

Select * from Products where CategoryID = 1 or CategoryID=3

Select * from Products where CategoryID = 1 and UnitPrice>=10

Select * from Products where CategoryID = 1 order by UnitPrice desc     -- asc / ascending = artan    --desc / descending = düşen azalan

Select count(*) from Products where CategoryID = 2

Select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

Select * from Products inner Join Categories on Products.CategoryID = Categories.CategoryID --Join Birleştirme  / C# da biz buna DTO Data Transformation object diyeceğiz 
                                                                                            -- yıldız tüm ürünleri listeler
Select Products.ProductID, Products.ProductName,Products.UnitPrice,Categories.CategoryID 
from Products inner Join Categories 
on Products.CategoryID = Categories.CategoryID  
where Products.UnitPrice>10


Select * from Products "p" left Join [Order Details] "od" --Order details arasında boşluk olduğu için farklı 2 kod olarak algılamasın diye köşeli parentez kullanıyoruz.
on p.ProductID = od.ProductID      -- yazıma göre solda olup sağda olmayanlarıda getir. (left join) / right join dr leftin tam tersi


Select * from Customers "c" left join Orders "o"
on c.CustomerID = o.CustomerID
where o.CustomerID is null  -- null lar is ile gösterilir

Select * from Products "p" inner Join [Order Details] "od" -- 2 den fazla tabloyu join etmek istersek
on p.ProductID = od.ProductID
inner join Orders "o"
on o.OrderID = od.OrderID

