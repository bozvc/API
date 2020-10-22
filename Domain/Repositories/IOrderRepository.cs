using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Domain.Models;

namespace CarRental.API.Domain.Repositories
{
    public interface IOrderRepository
    {

        Task<IEnumerable<Order>> ListAsync();
        Task AddAsync(Order category);
       
    }
}