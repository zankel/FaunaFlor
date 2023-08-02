using System.ComponentModel.DataAnnotations;

namespace FaunaFlor.Models
{
    public class Dieta
    {
        [Key]
        public int DietaId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        // Relacionamento um para muitos com Animal
        public List<Animal> Animais { get; set; }
    }
}
