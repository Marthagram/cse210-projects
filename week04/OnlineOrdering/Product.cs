public class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantityOfEachProduct;

    public Product(string name, string id, int price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantityOfEachProduct = quantity;

    }

    public int TotalCost()
    {
        int totalCost = _price * _quantityOfEachProduct;
        return totalCost;
    }
    
    public string GetProductName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

   
}