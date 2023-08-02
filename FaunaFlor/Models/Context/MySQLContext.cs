using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace FaunaFlor.Models.Context
{
    public class MySQLContext :DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Habitat> Habitats { get; set; }
        public DbSet<Dieta> Dietas { get; set; }
    }
}
