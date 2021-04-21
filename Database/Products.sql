CREATE TABLE [dbo].[Products]
(
	[ProductID] INT NOT NULL PRIMARY KEY, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [SupplierID] INT NOT NULL FOREIGN KEY REFERENCES SUPPLIERS(SupplierID),
    [CategoriesID] INT NOT NULL FOREIGN KEY REFERENCES Categories(CategoryID), 
    [Price] MONEY NOT NULL,

)
insert Products values (1,'Chais',1,1,18.00)
insert Products values (2,'Chang',1,1,19.00)
insert Products values (3,'Aniseed Syrup',1,2,10.00)
insert Products values (4,'Chef Anton’s Cajun Seasoning',2,2,22.00)
insert Products values (5,'Chef Anton’s Gumbo Mix',2,2,21.35)
select * from Products