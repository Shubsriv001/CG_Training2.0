SELECT OrderItems.*
FROM OrderItems
LEFT JOIN Orders
ON OrderItems.OrderId = Orders.OrderId
WHERE Orders.OrderId IS NULL;
