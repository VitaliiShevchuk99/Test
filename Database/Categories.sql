CREATE TABLE [dbo].[Categories]
(
	[CategoryID] INT NOT NULL PRIMARY KEY, 
    [CategoryName] NVARCHAR(50) NOT NULL, 
    [CategoryDescription] TEXT NOT NULL
)
insert Categories values (1,'Beverages','Soft drinks, coffees, teas, beers, and ales')
insert Categories values (2,'Condiments','Sweet and savory sauces, relishes, spreads, and seasonings')

insert Categories values (3,'Confections','Desserts, candies, and sweet breads')
insert Categories values (4,'Dairy Products','Cheeses')
insert Categories values (5,'Grains/Cereals','Breads, crackers, pasta, and cereal')
select * from Categories