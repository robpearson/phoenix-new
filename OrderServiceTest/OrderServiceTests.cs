namespace OrderServiceTest;

public class OrderServiceTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldGetSomeOrders()
    {
        var service = new OrderService.OrderService();
        var orders = service.GetOrders();
        Assert.That(orders, Is.Not.Empty);
    }

    [Test]
    public void ShouldSaveNewOrder()
    {
        var service = new OrderService.OrderService();
        service.SaveOrder();
        Assert.That(service, Is.Not.Null);
    }
}