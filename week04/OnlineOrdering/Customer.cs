public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsLivingInUSA()
    {
        bool local = _address.IsInUSA();
        if (local == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetDisplayText()
    {
        return $"{_name}\n{_address.GetDisplayText()}";
    }
}