public class Product
{
    private string _id;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string id, string name, double price, int quantity)
    {
        _id = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        {
            return _quantity * _price;
        }
    }

    public string GetPackingLabel()
    {
        {
            return $"- ID: {_id} | {_name}";
        }
    }
}