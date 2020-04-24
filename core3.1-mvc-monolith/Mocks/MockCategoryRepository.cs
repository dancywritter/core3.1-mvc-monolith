using System.Collections.Generic;

namespace core3._1_mvc_monolith.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Spicy Pizzas", Description="All-Spicyy Pizzas"},
                new Category{CategoryId=2, CategoryName="Meat Pizzas", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Vegetarian Pizzas", Description="Get in the mood for a Vegetarian Pizza"}
            };
    }
}
