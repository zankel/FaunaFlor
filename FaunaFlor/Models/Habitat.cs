﻿using System.ComponentModel.DataAnnotations;

namespace FaunaFlor.Models
{
    public class Habitat
    {
        [Key]
        public int HabitatId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(300)]
        public string Descricao { get; set; }

        [StringLength(300)]
        public string ImageURL { get; set; }

        // Relacionamento muitos para muitos com Animal
        public List<Animal> Animais { get; set; }
    }
}
