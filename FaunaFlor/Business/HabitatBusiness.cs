using FaunaFlor.Business.Implementations;
using FaunaFlor.Models;
using FaunaFlor.Repository;

namespace FaunaFlor.Business
{
    public class HabitatBusiness : IHabitatBusiness
    {
        private readonly IHabitatRepository _habitatRepository;

        public HabitatBusiness(IHabitatRepository habitatRepository)
        {
            _habitatRepository = habitatRepository;
        }

        public async Task<List<Habitat>> GetHabitatAsync()
        {
            return await _habitatRepository.GetHabitatAsync();
        }
    }
}
