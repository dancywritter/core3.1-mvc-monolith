using System.Collections.Generic;

namespace core3._1_mvc_monolith.Models
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> AllPizzas { get; }
        IEnumerable<Pizza> PizzasOfTheWeek { get; }
        Pizza GetPizzaById(int PizzaId);
    }
}
