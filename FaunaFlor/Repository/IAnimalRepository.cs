using FaunaFlor.Models;
using FaunaFlor.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace FaunaFlor.Repository
{
    public interface IAnimalRepository
    {
        Task<List<Animal>> GetAnimaisAsync();
    }
}
