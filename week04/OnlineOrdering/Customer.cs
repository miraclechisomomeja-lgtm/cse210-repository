

// The Customer class stores customer information and their address.
public class Customer
{
    // Private attributes protect customer information.
    private string _name;
    private Address _address;

    // Constructor initializes the customer's name and address.
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Returns the customer's name.
    public string GetName()
    {
        return _name;
    }

    // Returns the customer's Address object.
    public Address GetAddress()
    {
        return _address;
    }

    // Checks whether the customer lives in the USA.
    // It calls the IsInUSA() method from the Address class.
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}
