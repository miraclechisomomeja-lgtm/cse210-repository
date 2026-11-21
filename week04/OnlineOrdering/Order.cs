

using System.Collections.Generic;

// The Order class manages products and the customer
// associated with an order.
public class Order
{
    // A list stores multiple products in one order.
    private List<Product> _products;

    // Stores the customer who placed the order.
    private Customer _customer;

    // Constructor initializes the order and its customer.
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Adds a product to the order.
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculates the total order cost, including shipping.
    public double GetTotalCost()
    {
        double total = 0;

        // Calculate and add the cost of every product.
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping once, depending on the customer's location.
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // Generates a packing label containing product names and IDs.
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return label;
    }

    // Generates a shipping label containing the customer's
    // name and complete address.
    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL\n{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}";
    }
}
