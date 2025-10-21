using MyFirstBlazor.Services.Models;

namespace MyFirstBlazor.Services.Interfaces
{
    public interface IApiService
    {
        Task<IEnumerable<MovieModel>> GetAllAsync();
    }
}
