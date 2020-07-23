using System.Linq;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Mvc;
using Shop.UI.ViewModels;

namespace Shop.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IGuitarRepository _guitarRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IGuitarRepository guitarRepository, ShoppingCart shoppingCart)
        {
            _guitarRepository = guitarRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int guitarId)
        {
            var selectedGuitar = _guitarRepository.AllGuitars.FirstOrDefault(p => p.GuitarId == guitarId);

            if (selectedGuitar != null)
            {
                _shoppingCart.AddToCart(selectedGuitar, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int guitarId)
        {
            var selectedGuitar = _guitarRepository.AllGuitars.FirstOrDefault(p => p.GuitarId == guitarId);

            if (selectedGuitar != null)
            {
                _shoppingCart.RemoveFromCart(selectedGuitar);
            }
            return RedirectToAction("Index");
        }
    }
}
