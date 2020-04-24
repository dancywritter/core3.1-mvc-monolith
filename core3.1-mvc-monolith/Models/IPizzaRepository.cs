using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core3._1_mvc_monolith.Models
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> AllPizzas { get; }
        IEnumerable<Pizza> PizzasOfTheWeek { get; }
        Pizza GetPizzaById(int PizzaId);
    }
}
