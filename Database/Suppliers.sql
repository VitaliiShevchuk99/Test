CREATE TABLE [dbo].[Suppliers]
(
	[SupplierId] INT NOT NULL PRIMARY KEY,
	[SupplierName] NVARCHAR(50) not null, 
    [City] NVARCHAR(50) NOT NULL, 
    [Country] NVARCHAR(50) NULL,
	
)
insert Suppliers values (1,'Exotic Liquid','London','UK')
insert Suppliers values (2,'New Orleans Cajun Delights','New Orleans','USA')
insert Suppliers values (3,'Grandma Kelly’s Homestead','Ann Arbor','USA')
insert Suppliers values (4,'Tokyo Traders','Tokyo','Japan')
insert Suppliers values (5,'Cooperativa de Quesos ‘Las Cabras’','Oviedo','Spain')
select * from Suppliers