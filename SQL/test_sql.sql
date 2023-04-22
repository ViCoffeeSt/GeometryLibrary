SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT OUTER JOIN Product_Category
ON Products.ProductID = Product_Category.ProductID
LEFT OUTER JOIN Categories
ON Product_Category.CategoryID = Categories.CategoryID
