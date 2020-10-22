using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRental.API.Domain.Models;
using CarRental.API.Domain.Repositories;
using CarRental.API.Persistence.Contexts;

namespace CarRental.API.Persistence.Repositories
{
    public class AutomobileRepository : BaseRepository, IAutomobileRepository
    {
        public AutomobileRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Automobile>> ListAsync()
        {
            return await _context.Automobile.Include(p => p.Category)
                                          .ToListAsync();
        }
       
    }
}