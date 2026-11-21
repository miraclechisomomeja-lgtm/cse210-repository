class Program
{
    static void Main(string[] args)
    {

        // FIRST CUSTOMER - USA

        // Create the first customer's address.
        Address address1 = new Address(
           "233 S Wacker Drive",
            "Chicago",
            "Illinois",
            "USA"
        );

        // Create the first customer using the address.
        Customer customer1 = new Customer("John Doe", address1);


        // PRODUCTS FOR THE FIRST ORDER    

        // Create three products for the first customer.
        Product product1 = new Product("Laptop", "LAP101", 20, 2);
        Product product2 = new Product("Laptop Bag", "LB102", 5, 3);
        Product product3 = new Product("Wireless Mouse", "WM103", 15, 1);


        // FIRST ORDER

        // Create an order belonging to the first customer.
        Order order1 = new Order(customer1);

        // Add the three products to the first order.
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // DISPLAY FIRST ORDER INFORMATION

        // Display the first order heading and customer name.
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine($"Customer: {customer1.GetName()}");
        Console.WriteLine();

        // Display the packing label.
        Console.WriteLine(order1.GetPackingLabel());

        // Display the shipping label.
        Console.WriteLine(order1.GetShippingLabel());

        // Display the final order cost, including shipping.
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();


        // SECOND CUSTOMER - NIGERIA

        // Create the second customer's address.
        Address address2 = new Address(
            "15 Ebenator Road",
            "Orlu",
            "Imo State",
            "Nigeria"
        );

        // Create the second customer using the address.
        Customer customer2 = new Customer("Chisom Omeja", address2);



        // PRODUCTS FOR THE SECOND ORDER


        // Create three products for the second customer.
        Product product4 = new Product("Ring Light", "RL104", 50, 1);
        Product product5 = new Product("Microphone", "MIC105", 15, 1);
        Product product6 = new Product("Headphone", "HP106", 10, 1);



        // SECOND ORDER


        // Create an order belonging to the second customer.
        Order order2 = new Order(customer2);

        // Add the three products to the second order.
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);



        // DISPLAY SECOND ORDER INFORMATION


        // Display the second order heading and customer name.
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine($"Customer: {customer2.GetName()}");
        Console.WriteLine();

        // Display the packing label.
        Console.WriteLine(order2.GetPackingLabel());

        // Display the shipping label.
        Console.WriteLine(order2.GetShippingLabel());

        // Display the final order cost, including shipping.
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine();
    }
}