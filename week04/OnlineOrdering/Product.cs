// The Product class stores information about individual products.
public class Product
{
    // Private attributes protect product information.
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor initializes the product details.
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Returns the product name.
    public string GetName()
    {
        return _name;
    }

    // Returns the product ID.
    public string GetProductId()
    {
        return _productId;
    }

    // Returns the price per unit.
    public double GetPrice()
    {
        return _price;
    }

    // Returns the quantity purchased.
    public int GetQuantity()
    {
        return _quantity;
    }

    // Calculates the total cost of this product.
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
