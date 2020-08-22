using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Shop.UI.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Shop.UI.Controllers
{
    public class GuitarController : Controller
    {
        private readonly IGuitarRepository _guitarRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GuitarController(IGuitarRepository guitarRepository, ICategoryRepository categoryRepository)
        {
            _guitarRepository = guitarRepository;
            _categoryRepository = categoryRepository;
        }

     
        //public IActionResult List()
        //{
        //    //ViewBag.CurrentCategory = "Electric Guitar";

        //    //return View(_guitarRepository.AllGuitars);
        //    GuitarsListViewModel guitarsListViewModel = new GuitarsListViewModel();
        //    guitarsListViewModel.Guitars = _guitarRepository.AllGuitars;
        //    guitarsListViewModel.CurrentCategory = "Electric Guitars";
        //    return View(guitarsListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Guitar> guitars;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                guitars = _guitarRepository.AllGuitars.OrderBy(p => p.GuitarId);
                currentCategory = "All guitars";
            }
            else
            {
                guitars = _guitarRepository.AllGuitars.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.GuitarId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new GuitarsListViewModel
            {
                Guitars = guitars,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var guitar = _guitarRepository.GetGuitarsById(id);
            if (guitar == null)
                return NotFound();

            return View(guitar);
        }
    }
}
