using Microsoft.EntityFrameworkCore;
using Onion.Application.Services;
using Onion.Domain.Interfaces;
using Onion.Infrastructure.Data;
using Onion.Infrastructure.Repositories;

namespace Onion.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("OrdersDb"));

            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<OrderService>();


            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
