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

        public async Task<IActionResult> Index()
        {
            var habitat = await _habitatBusiness.GetHabitatAsync();
            return View(habitat);
        }
    }
}
