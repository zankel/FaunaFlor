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

        public async Task<IActionResult> Index()
        {
            var animais = await _animalBusiness.GetAnimaisAsync();
            return View(animais);
        }

    }
}
