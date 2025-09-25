using System;

class Program
{
    static void Main(string[] args)
    {

        Product pro1 = new Product("Packs of Sugar", "234", 4, 5 );
        Product pro2 = new Product("Carton of Sardines", "249", 8, 10 );
        Product pro3 = new Product("Packs of Butter", "257", 7, 15 );

        Product pro4 = new Product("Bag of Beans", "334", 6, 5 );
        Product pro5 = new Product("Pack of Children Clothes", "270", 6, 14 );
        Product pro6 = new Product("Carton of Tiles", "297", 9, 6 );

        Product pro7 = new Product("Carton of Spaghetti", "333", 25, 5 );
        Product pro8 = new Product("Packs of Sweets", "221", 20, 10 );
        Product pro9 = new Product("Box of Shoes", "311", 30, 15 );


        Address addy1 = new Address("Mainstreet", "New York City", "New York", "USA");
        Address addy2 = new Address("Yonge Street", "Toronto", "Ontario", "Canada");
        Address addy3= new Address("Via del Corso", "Rome", "Lazio", "Italy");


        Customer cust1 = new Customer("Justice", addy1 );
        Customer cust2 = new Customer("Jordan", addy2 );
        Customer cust3 = new Customer("Gabriella", addy3 );

        Order order1 = new Order(pro1, pro2, pro3, cust1);
        Order order2 = new Order(pro4, pro5, pro6, cust2);
        Order order3 = new Order(pro7, pro8, pro9, cust3);

        Console.WriteLine("\n");
        Console.WriteLine($"Shipping Label-\n{order1.ShippingLabel()}");
        Console.WriteLine("\n");
        Console.WriteLine($"Packing Label-\n{order1.PackingLabel()}");
        Console.WriteLine("\n");
        order1.TotalPrice();
        Console.WriteLine("---------------------------------------------------------------------------");
        
        
        Console.WriteLine("\n");
        Console.WriteLine($"Shipping Label-\n{order2.ShippingLabel()}");
        Console.WriteLine("\n");
        Console.WriteLine($"Packing Label-\n{order2.PackingLabel()}");
        Console.WriteLine("\n");
        order2.TotalPrice();
        Console.WriteLine("---------------------------------------------------------------------------");
        

        Console.WriteLine("\n");
        Console.WriteLine($"Shipping Label-\n{order3.ShippingLabel()}");
        Console.WriteLine("\n");
        Console.WriteLine($"Packing Label-\n{order3.PackingLabel()}");
        Console.WriteLine("\n");
        order3.TotalPrice();
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Thank you for E-shopping with us!");

    }
}