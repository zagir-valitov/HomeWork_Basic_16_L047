using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataAccess;
using LinqToDB.Models;

Console.WriteLine(" --- Home Work 16 Linq To DB ---\n");

DataConnection.DefaultSettings = new DbConnectionSettings();
DbConnection db = new DbConnection();

var customer = new CustomerData(db);    
var customersList = customer.GetCustomers().Result;
foreach (var c in customersList)
{
    Console.WriteLine($"First Name: {c.FirstName} \tLast Name: {c.LastName} \tAge: {c.Age}");
}
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------------------");

var product = new ProductData(db);
var productsList = product.GetProducts().Result;
foreach (var p in productsList)
{
    Console.WriteLine(
        $"Name: {p.ProductName} \tDescription: {p.Description} " +
        $"\tStock Quantity: {p.StockQuantity} \tPrice: {p.Price}");
}
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------------------");

var order = new OrderData(db);
var ordersList = order.GetOrders().Result;
foreach (var o in ordersList)
{
    Console.WriteLine($"Order ID: {o.OrderID}, \tProduct ID: {o.ProductID}, \tQuantity: {o.Quantity}");
}
Console.ReadLine();
Console.WriteLine("------------------------------------------------------------------------------");

var orderUpdate1 = new OrderModel
{
    OrderID = 8,
    CustomerID = 2,
    ProductID = 1,
    Quantity = 1234
};

var orCount = order.UpdateOrder(orderUpdate1);

var customerOver30ByOrderID = 
    from c in db.Customers
    join o in db.Orders on c.CustomerID equals o.CustomerID
    join p in db.Products on o.ProductID equals p.ProductID
    where o.ProductID == 1 && c.Age > 30
    select new
    {
        OrderID = o.OrderID,
        CustomerID = c.CustomerID,
        FirstName = c.FirstName,
        LastName = c.LastName,
        ProductID = p.ProductID,
        Quantity = o.Quantity,
        Price = p.Price
    };

foreach (var c in customerOver30ByOrderID)
{
    Console.WriteLine(
        $"Order ID: \t{c.OrderID}\n" +
        $"Customer ID: \t{c.CustomerID}\n" +
        $"First Name: \t{c.FirstName}\n" +
        $"Last Name: \t{c.LastName}\n" +
        $"Product ID: \t{c.ProductID}\n" +
        $"Quantity: \t{c.Quantity}\n" +
        $"Price: \t\t{c.Price}\n\n");
}