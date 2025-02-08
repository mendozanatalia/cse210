using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address
        Address address1 = new Address("123 Main Street", "Los Angeles", "CA", "USA");
        Address address2 = new Address("280 Other Street", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Natalia Mendoza", address1);
        Customer customer2 = new Customer("Camilo Caillavy", address2);
        Customer customer3 = new Customer("Fabiana Siacara", address2);

        // Create products
        Product product1 = new Product("L001", "Laptop", 1200, 1);
        Product product2 = new Product("M002", "Mouse", 25, 2);
        Product product3 = new Product("K003", "Keyboard", 50, 1);
        Product product4 = new Product("T004", "Tablet", 300, 1);

        // Create orders
        Order order1 = new Order([product2], customer1);
        Order order2 = new Order([product3, product4], customer2);
        Order order3 = new Order([product1, product2, product4], customer3);

        List<Order> orders = new List<Order> 
        {
            order1, order2, order3
        };

        foreach (Order order in orders)
        {
            Console.WriteLine(new string('=', 40));

            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"TOTAL COST: {order.GetTotalCost()}$\n");
        }

    }
}