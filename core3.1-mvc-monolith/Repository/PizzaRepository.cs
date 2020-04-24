using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace core3._1_mvc_monolith.Models
{
    public class PizzaRepository: IPizzaRepository
    {
        private readonly AppDbContext _appDbContext;

        public PizzaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pizza> AllPizzas
        {
            get
            {
                return _appDbContext.Pizzas.Include(c => c.Category);
            }
        }

        public IEnumerable<Pizza> PizzasOfTheWeek
        {
            get
            {
                return _appDbContext.Pizzas.Include(c => c.Category).Where(p => p.IsPizzaOfTheWeek);
            }
        }

        public Pizza GetPizzaById(int PizzaId)
        {
            return _appDbContext.Pizzas.FirstOrDefault(p => p.PizzaId == PizzaId);
        }
    }
}
