SELECT P.Name As 'Products', C.Name As 'Categories'
FROM Products P
LEFT JOIN CategoriesProducts CP
ON P.Id = CP.ProductId
LEFT JOIN Categories C
ON CP.CategoryId = C.Id;
