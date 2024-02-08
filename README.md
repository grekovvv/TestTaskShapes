# TestTaskShapes

SQL Query:

SELECT p.Name AS ProductName, ISNULL(c.Name, 'Нет категории') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id;
