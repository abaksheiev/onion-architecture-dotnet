using Onion.Domain.Entities;
using Onion.Domain.Interfaces;

namespace Onion.Infrastructure;

public class OrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<Guid> CreateOrderAsync(string customerName, decimal totalAmount)
    {
        var order = new Order(customerName, totalAmount);
        await _orderRepository.AddAsync(order);
        return order.Id;
    }
}
