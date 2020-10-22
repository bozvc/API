using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRental.API.Domain.Models;
using CarRental.API.Domain.Repositories;
using CarRental.API.Persistence.Contexts;

namespace CarRental.API.Persistence.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Order>> ListAsync()
        {
            return await _context.Order.Include(p => p.Automobile).ThenInclude(p => p.Category)
                                          .ToListAsync();
        }

        public async Task AddAsync(Order order)
	    {
		    await _context.Order.AddAsync(order);
	    }

       
    }
}