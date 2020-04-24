using System.Collections.Generic;
using System.Linq;
using core3._1_mvc_monolith.Models;
using core3._1_mvc_monolith.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace core3._1_mvc_monolith.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _PizzaRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PizzaController(IPizzaRepository PizzaRepository, ICategoryRepository categoryRepository)
        {
            _PizzaRepository = PizzaRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Pizza> Pizzas;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                Pizzas = _PizzaRepository.AllPizzas.OrderBy(p => p.PizzaId);
                currentCategory = "All Pizzas";
            }
            else
            {
                Pizzas = _PizzaRepository.AllPizzas.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PizzaId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new PizzasListViewModel
            {
                Pizzas = Pizzas,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var Pizza = _PizzaRepository.GetPizzaById(id);
            if (Pizza == null)
                return NotFound();

            return View(Pizza);
        }
    }
}
