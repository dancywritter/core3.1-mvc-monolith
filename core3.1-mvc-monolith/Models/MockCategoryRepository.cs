using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core3._1_mvc_monolith.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Pizzas", Description="All-fruity Pizzas"},
                new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Seasonal Pizzas", Description="Get in the mood for a seasonal Pizza"}
            };
    }
}
