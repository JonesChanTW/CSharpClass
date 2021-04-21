Select o.* from Orders o left join Employees e 
on e.EmployeeID = o.EmployeeID 
where o.OrderID in 
(Select od.OrderID from `Order Details` od where UnitPrice > 50)