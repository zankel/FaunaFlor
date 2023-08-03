using FaunaFlor.Models;
using FaunaFlor.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace FaunaFlor.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly MySQLContext _context;

        public AnimalRepository(MySQLContext context)
        {
            _context = context;
        }

        public async Task<List<Animal>> GetAnimaisAsync()
        {
            return await _context.Animais
                .Include(a =>a.Dieta)
                .Include(a => a.Habitats)
                .ToListAsync();
        }

        public async Task<Animal> GetAnimaisByIdAsync(int id)
        {
            return await _context.Animais
                .Include(a => a.Dieta)
                .Include(a => a.Habitats)
                .FirstOrDefaultAsync(a => a.AnimalId == id);
        }
    }

}
