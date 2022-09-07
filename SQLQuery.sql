SELECT Products.ProductName, Categories.CategoryName
FROM Products
FULL OUTER JOIN Categories ON Products.ProductID=Categories.ProductID
ORDER BY Products.ProductName;