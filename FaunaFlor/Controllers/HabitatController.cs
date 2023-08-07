using FaunaFlor.Business;
using FaunaFlor.Business.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace FaunaFlor.Controllers
{
    public class HabitatController : Controller
    {
        private readonly IHabitatBusiness _habitatBusiness;

        public HabitatController(IHabitatBusiness habitatBusiness)
        {
            _habitatBusiness = habitatBusiness;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var habitats = await _habitatBusiness.GetHabitatAsync();


            if (!string.IsNullOrEmpty(searchString))
            {
                habitats = habitats
                    .Where(a => a.Nome.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return View(habitats);
        }

        public async Task<IActionResult> HabitatDetalhes(int id)
        {
            var habitat = await _habitatBusiness.GetHabitatByIdAsync(id);
            return View(habitat);
        }
    }
}
