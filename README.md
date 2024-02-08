# TestTaskShapes

A test project whose task is to calculate the area of the figures. 
There is a class library, unit tests and the client part is implemented in the form of Console App. 


### Additionally:
SQL Query:

SELECT p.Name AS ProductName, ISNULL(c.Name, 'Нет категории') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id;
