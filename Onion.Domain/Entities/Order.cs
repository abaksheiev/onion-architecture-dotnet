namespace Onion.Domain.Entities;
public class Order
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; }
    public decimal TotalAmount { get; set; }

    public Order(string customerName, decimal totalAmount)
    {
        Id = Guid.NewGuid();
        CustomerName = customerName;
        TotalAmount = totalAmount;
    }
}