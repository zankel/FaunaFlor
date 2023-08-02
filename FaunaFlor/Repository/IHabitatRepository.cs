using FaunaFlor.Models;

namespace FaunaFlor.Repository
{
    public interface IHabitatRepository
    {
        Task<List<Habitat>> GetHabitatAsync();
    }
}
