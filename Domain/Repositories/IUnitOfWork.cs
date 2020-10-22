using System.Threading.Tasks;

namespace CarRental.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}