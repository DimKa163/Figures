SELECT [Product].[Name] product, [Category].[Name] Category FROM [ProductCategory]
RIGHT JOIN [Product] ON [Product].[Id]=[ProductCategory].[ProductId]
LEFT JOIN [Category] ON [ProductCategory].[CategoryId]=[Category].[Id]