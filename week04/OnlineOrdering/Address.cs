
// The Address class stores and manages customer address information.
public class Address
{
    // Private attributes store the address details.
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor initializes the address.
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Checks whether the customer's address is in the USA.
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    // Returns the complete address as a formatted string.
    // The \n character moves each address detail to a new line.
    public string GetAddress()
    {
        return $"{_street}\n{_city}\n{_state}\n{_country}";
    }
}


