using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Domain.Models;
using CarRental.API.Domain.Services.Communication;

namespace CarRental.API.Domain.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> ListAsync();
        Task<OrderResponse> SaveAsync(Order order);

    }
}