using FaunaFlor.Models.Context;
using FaunaFlor.Models;
using Microsoft.EntityFrameworkCore;

namespace FaunaFlor.Repository
{
    public class HabitatRepository : IHabitatRepository
    {
        private readonly MySQLContext _context;

        public HabitatRepository(MySQLContext context)
        {
            _context = context;
        }

        public async Task<List<Habitat>> GetHabitatAsync()
        {
            return await _context.Habitats.ToListAsync();
        }

        public async Task<Habitat> GetHabitatByIdAsync(int id )
        {
            return await _context.Habitats.FirstOrDefaultAsync(h => h.HabitatId == id);
        }
    }
}
