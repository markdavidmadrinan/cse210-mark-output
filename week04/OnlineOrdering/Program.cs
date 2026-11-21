using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // Products for first order
        Product product1 = new Product("Laptop", "P1001", 800.00, 1);
        Product product2 = new Product("Mouse", "P1002", 25.00, 2);
        Product product3 = new Product("Keyboard", "P1003", 45.00, 1);

        // Create first order
        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // Second customer
        Address address2 = new Address(
            "456 Rizal Street",
            "Nagcarlan",
            "Laguna",
            "Philippines"
        );

        Customer customer2 = new Customer("Maria Santos", address2);

        // Products for second order
        Product product4 = new Product("Smartphone", "P2001", 500.00, 1);
        Product product5 = new Product("Phone Case", "P2002", 15.00, 2);
        Product product6 = new Product("Headphones", "P2003", 60.00, 1);

        // Create second order
        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // Display first order
        Console.WriteLine("==============================");
        Console.WriteLine("          ORDER 1");
        Console.WriteLine("==============================");

        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine("Total Price: $" +
            order1.GetTotalCost().ToString("F2"));


        // Display second order
        Console.WriteLine();
        Console.WriteLine("==============================");
        Console.WriteLine("          ORDER 2");
        Console.WriteLine("==============================");

        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine("Total Price: $" +
            order2.GetTotalCost().ToString("F2"));

        Console.WriteLine();
        Console.WriteLine("==============================");
        Console.WriteLine("        END OF ORDERS");
        Console.WriteLine("==============================");
    }
}