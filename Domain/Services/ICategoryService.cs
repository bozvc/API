using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Domain.Models;
using CarRental.API.Domain.Services.Communication;

namespace CarRental.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}