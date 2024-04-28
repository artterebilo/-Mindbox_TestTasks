SELECT PRODUCTS.NAME as ProductName, CATEGORIES.NAME as CategoryName FROM PRODUCTS
LEFT JOIN PRODUCTCATEGORIES ON PRODUCTS.ID = PRODUCTCATEGORIES.PRODUCTID
LEFT JOIN CATEGORIES ON CATEGORIES.ID = PRODUCTCATEGORIES.CATEGORYID