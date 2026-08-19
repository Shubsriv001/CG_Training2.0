SELECT p.* FROM Products p LEFT JOIN Sales s  ON p.ProductId = s.ProductId WHERE s.ProductId IS NULL;
