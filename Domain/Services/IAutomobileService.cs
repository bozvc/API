using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Domain.Models;

namespace CarRental.API.Domain.Services
{
    public interface IAutomobileService
    {
         Task<IEnumerable<Automobile>> ListAsync();

    }
}