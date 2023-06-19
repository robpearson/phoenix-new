namespace OrderService;

public class OrderService
{
    public IList<string> GetOrders()
    {
        return new List<string> { "Order 1", "Order 2", "Order 3" };
    }

    public void SaveOrder()
    {
        // TODO: Implement
    }

    public void UpdateOrder()
    {
        // TODO: Implement
    }
}