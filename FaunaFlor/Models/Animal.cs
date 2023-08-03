using System.ComponentModel.DataAnnotations;

namespace FaunaFlor.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(300)]
        public string Descricao { get; set; }

        [Required]
        [StringLength(int.MaxValue)]
        public string DescricaoPrincipal { get; set; }

        [StringLength(300)]
        public string ImageURL { get; set; }

        // Relacionamento muitos para muitos com Habitat
        public List<Habitat> Habitats { get; set; }

        // Chave estrangeira para Dieta (um para muitos)
        public int DietaId { get; set; }
        public Dieta Dieta { get; set; }
    }
}
