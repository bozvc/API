using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Domain.Models;
using CarRental.API.Domain.Repositories;
using CarRental.API.Domain.Services;

namespace CarRental.API.Services
{
    public class AutomobileService : IAutomobileService
    {
        private readonly IAutomobileRepository _automobileRepository;
    
        public AutomobileService(IAutomobileRepository automobileRepository)
        {
            _automobileRepository = automobileRepository;
        }

        public async Task<IEnumerable<Automobile>> ListAsync()
        {
            return await _automobileRepository.ListAsync();
        }
       
    }
}