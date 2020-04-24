using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core3._1_mvc_monolith.Models;
using core3._1_mvc_monolith.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace core3._1_mvc_monolith.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPizzaRepository _PizzaRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPizzaRepository PizzaRepository, ShoppingCart shoppingCart)
        {
            _PizzaRepository = PizzaRepository;
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

        public RedirectToActionResult AddToShoppingCart(int PizzaId)
        {
            var selectedPizza = _PizzaRepository.AllPizzas.FirstOrDefault(p => p.PizzaId == PizzaId);

            if (selectedPizza != null)
            {
                _shoppingCart.AddToCart(selectedPizza, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int PizzaId)
        {
            var selectedPizza = _PizzaRepository.AllPizzas.FirstOrDefault(p => p.PizzaId == PizzaId);

            if (selectedPizza != null)
            {
                _shoppingCart.RemoveFromCart(selectedPizza);
            }
            return RedirectToAction("Index");
        }
    }
}
