using System.Collections.Generic;
using core3._1_mvc_monolith.Models;

namespace core3._1_mvc_monolith.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pizza> PizzasOfTheWeek { get; set; }
    }
}
