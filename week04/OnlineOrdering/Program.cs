using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Av Richmond 746", "Lehi", "Utah", "USA");
        Customer customer1 = new Customer("John Paul Williams", address1);
        Product product1 = new Product("Science Book", 567, 15.99, 2);
        Product product2 = new Product("Notebook", 234, 8.99, 4);
        Product product3 = new Product("Laptop", 345, 78.99, 1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("\nOrder 001");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}\n");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${Math.Round(order1.CalculateTotalCost(), 2)}");

        Address address2 = new Address("San Luis 3944", "Mar del Plata", "Buenos Aires", "Argentina");
        Customer customer2 = new Customer("Pablo Martin Lopez", address2);
        Product product4 = new Product("Book of Mormon", 1902, 10.99, 15);
        Product product5 = new Product("Microphone", 123, 49.99, 3);
        Product product6 = new Product("Speaker", 127, 59.99, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("\nOrder 002");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}\n");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${Math.Round(order2.CalculateTotalCost(), 2)}");
    }
}