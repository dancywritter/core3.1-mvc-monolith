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
    public class HomeController : Controller
    {
        private readonly IPizzaRepository _PizzaRepository;

        public HomeController(IPizzaRepository PizzaRepository)
        {
            _PizzaRepository = PizzaRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PizzasOfTheWeek = _PizzaRepository.PizzasOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
