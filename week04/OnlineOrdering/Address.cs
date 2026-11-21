public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Getters and Setters
    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    // Check if the address is in the USA
    public bool IsInUSA()
    {
        if (_country == "USA" || _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Return the complete address
    public string GetAddressString()
    {
        return _street + "\n" +
               _city + ", " + _state + "\n" +
               _country;
    }
}