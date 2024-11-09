SELECT 
    p.Name,
    c.Name
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.Id = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.Id;