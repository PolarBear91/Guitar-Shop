using Data_Access_Layer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shop.UI.ViewModels;

namespace Shop.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGuitarRepository _guitarRepository;

        public HomeController(IGuitarRepository guitarRepository)
        {
            _guitarRepository = guitarRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                GuitarsOfTheWeek = _guitarRepository.GuitarsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
