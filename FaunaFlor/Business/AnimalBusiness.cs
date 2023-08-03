using FaunaFlor.Business.Implementations;
using FaunaFlor.Models;
using FaunaFlor.Repository;

namespace FaunaFlor.Business
{
    public class AnimalBusiness : IAnimalBusiness
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalBusiness(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task<List<Animal>> GetAnimaisAsync()
        {
            return await _animalRepository.GetAnimaisAsync();
        }

        public async Task<Animal> GetAnimaisByIdAsync(int id)
        {
            return await _animalRepository.GetAnimaisByIdAsync(id);
        }
    }
}
