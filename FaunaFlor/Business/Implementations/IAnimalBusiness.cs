using FaunaFlor.Models;

namespace FaunaFlor.Business.Implementations
{
    public interface IAnimalBusiness
    {
        Task<List<Animal>> GetAnimaisAsync();
    }
}
