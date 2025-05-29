namespace Onion.Api.Controllers;


using Microsoft.AspNetCore.Mvc;
using Onion.Application.Services;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly OrderService _orderService;

    public OrdersController(OrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(string customerName, decimal totalAmount)
    {
        var orderId = await _orderService.CreateOrderAsync(customerName, totalAmount);
        return Ok(orderId);
    }
}