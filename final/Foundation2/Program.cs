using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Temple Square", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("500 Central Avenue", "São Paulo", "SP", "Brazil");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Nefi Muniz", address2);

        // Create products
        Product product1 = new Product("Laptop", "LAP123", 999.99m, 1);
        Product product2 = new Product("Mouse", "MOU456", 49.99m, 2);
        Product product3 = new Product("Keyboard", "KEY789", 89.99m, 1);
        Product product4 = new Product("Monitor", "MON012", 199.99m, 2);
        Product product5 = new Product("Chair", "CHA345", 149.99m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order.GetTotalCost():C}");
        Console.WriteLine();
    }
}
