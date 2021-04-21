select * from Products where  ProductName like 'C%' 

select * from Products order by Price OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY;

select * from Products where SupplierID in
(
	select SupplierID from Suppliers where Country='USA'
);

select * from suppliers where SupplierID in
(
	select supplierID from products where categoriesID in
	(
		select categoryID from categories where categoryname='Condiments'
	)
);

insert Suppliers values (6,'Norske Meierier','Lviv','Ukraine')
insert Products values (6,'Green tea',6,1,10.00)

select * from products