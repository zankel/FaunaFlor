using FaunaFlor.Business.Implementations;
using FaunaFlor.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FaunaFlor.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimalBusiness _animalBusiness;

        public AnimalController(IAnimalBusiness animalService)
        {
            _animalBusiness = animalService;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var animais = await _animalBusiness.GetAnimaisAsync();

          
            if (!string.IsNullOrEmpty(searchString))
            {
                animais = animais
                    .Where(a => a.Nome.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return View(animais);
        }

        public async Task<IActionResult> AnimalDetalhes(int id)
        {
            var animal = await _animalBusiness.GetAnimaisByIdAsync(id);
            return View(animal);
        }

    }
}
