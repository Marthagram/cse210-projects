public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public Order(Product product, Product product2, Product product3, Customer customer)
    {
        _products.Add(product);
        _products.Add(product2);
        _products.Add(product3);
        _customer = customer;

    }
    public void TotalPrice()

    {   
        int usaShippingCost = 5;
        int internationalShippingCost = 35;
        int totalPrice = 0;
    
         foreach (Product prod in _products)
        {
            totalPrice += prod.TotalCost();
        }

        if (_customer.Location() == "USA")
        {
            totalPrice += usaShippingCost;
            Console.WriteLine($"The Total Price of the order with $5 local Shipping fee added is ${totalPrice}");
        }
        else
        {
            totalPrice += internationalShippingCost;
            Console.WriteLine($"The Total Price of the order with $35 international Shipping fee added is ${totalPrice}");
        }


    }

    public string ShippingLabel()
    {
        return $"Customer Name: {_customer.GetName()}, Address: {_customer.GetAddress().MyAddress()}";
    }  

    public string PackingLabel()
    {
        string label = "";
        foreach (Product prod in _products)
        {
            label += $"{prod.GetProductName()}, Product Id: {prod.GetProductId()}\n";
        }
        return label;
    }
      
}