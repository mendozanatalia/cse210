public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost;

        if (_customer.IsInUSA())
        {
            shippingCost = 5; // In USA
        }
        else
        {
            shippingCost = 35; // Out USA
        }

        // Use Math.Round in order to have 2 decimals.
        double finalTotal = Math.Round(total, 2) + shippingCost;
        return finalTotal;
    }

    public string GetPackingLabel()
    {
        {
            string packingLabel = "Packing List:\n";

            foreach (Product product in _products)
            {
                packingLabel += product.GetPackingLabel() + "\n";
            }
            return packingLabel;
        }
    }

    public string GetShippingLabel()
    {
        {
            return $"SHIPPING TO: {_customer.GetShippingLabel()}";
        }
    }
}