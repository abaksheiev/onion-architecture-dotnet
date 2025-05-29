using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using Onion.Infrastructure.Data;
using Onion.Infrastructure.Repositories;

namespace Onion.Tests.Integration;

public class OrderRepositoryTests
{
    private AppDbContext GetDbContext()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;

        return new AppDbContext(options);
    }

    [Fact]
    public async Task AddAndGetOrder_ShouldPersistOrder()
    {
        // Arrange
        var context = GetDbContext();
        var repo = new OrderRepository(context);
        var order = new Order("Bob", 150);

        // Act
        await repo.AddAsync(order);
        var result = await repo.GetByIdAsync(order.Id);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Bob", result.CustomerName);
        Assert.Equal(150, result.TotalAmount);
    }
}

