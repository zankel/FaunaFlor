using FaunaFlor.Models;

namespace FaunaFlor.Business.Implementations
{
    public interface IHabitatBusiness
    {
        Task<List<Habitat>> GetHabitatAsync();
        Task<Habitat> GetHabitatByIdAsync(int id);

    }
}
