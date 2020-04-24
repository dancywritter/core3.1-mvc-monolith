using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core3._1_mvc_monolith.Models
{
    public class MockPizzaRepository: IPizzaRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pizza> AllPizzas =>
            new List<Pizza>
            {
                 new Pizza
                         {
                             PizzaId = 1,
                             AllergyInformation = "",
                             CategoryId = 1,
                             ImagePath = "~/Images/pizzas/cheese-pizza.png",
                             ImageThumbnailPath = "~/Images/thumbnails/cheese-small.png",
                             InStock = true,
                             IsPizzaOfTheWeek = true,
                             LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                             Name = "Cheese Pizza",
                             Price = 15.50m,
                             ShortDescription = "Our famous Cheese Pizzas!"
                         },
                    new Pizza
                    {
                        PizzaId = 2,
                        AllergyInformation = "",
                        CategoryId = 1,
                        ImagePath = "~/Images/pizzas/cheese-pizza.png",
                        ImageThumbnailPath = "~/Images/thumbnails/cheese-small.png",
                        InStock = true,
                        IsPizzaOfTheWeek = false,
                        LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                        Name = "Cheese Pizza",
                        Price = 16.00m,
                        ShortDescription = "Our famous Cheese Pizzas!"
                    },
                      new Pizza
                      {
                          PizzaId = 3,
                          AllergyInformation = "",
                          CategoryId = 1,
                          ImagePath = "~/Images/pizzas/chicken-cheese-pizza.png",
                          ImageThumbnailPath = "~/Images/thumbnails/chicken-small.png",
                          InStock = true,
                          IsPizzaOfTheWeek = true,
                          LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                          Name = "Chicken Trio Pizza",
                          Price = 15.00m,
                          ShortDescription = "3 Chickens made it!"
                      },
                        new Pizza
                        {
                            PizzaId = 4,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImagePath = "~/Images/pizzas/chicken-cheese-pizza.png",
                            ImageThumbnailPath = "~/Images/thumbnails/chicken-small.png",
                            InStock = true,
                            IsPizzaOfTheWeek = false,
                            LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                            Name = "Chicken Trio Pizza",
                            Price = 18.95m,
                            ShortDescription = "3 Chickens made it!"
                        },
                          new Pizza
                          {
                              PizzaId = 5,
                              AllergyInformation = "",
                              CategoryId = 1,
                              ImagePath = "~/Images/pizzas/pepperoni-pizza.png",
                              ImageThumbnailPath = "~/Images/thumbnails/pepperoni-small.png",
                              InStock = true,
                              IsPizzaOfTheWeek = true,
                              LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                              Name = "Pepparoni Chedder Pizza",
                              Price = 17.50m,
                              ShortDescription = "Have a party with this Pizza!"
                          },
                            new Pizza
                            {
                                PizzaId = 6,
                                AllergyInformation = "",
                                CategoryId = 1,
                                ImagePath = "~/Images/pizzas/meat-pizza.png",
                                ImageThumbnailPath = "~/Images/thumbnails/meat-small.png",
                                InStock = true,
                                IsPizzaOfTheWeek = false,
                                LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                                Name = "Spicy Meat Pizza",
                                Price = 12.95m,
                                ShortDescription = "If you can handle spice!"
                            },
                              new Pizza
                              {
                                  PizzaId = 7,
                                  AllergyInformation = "",
                                  CategoryId = 1,
                                  ImagePath = "~/Images/pizzas/meat-pizza.png",
                                  ImageThumbnailPath = "~/Images/thumbnails/meat-small.png",
                                  InStock = true,
                                  IsPizzaOfTheWeek = true,
                                  LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                                  Name = "Spicy Meat Pizza",
                                  Price = 19.00m,
                                  ShortDescription = "Real Spice Real Pizza!"
                              },
                                new Pizza
                                {
                                    PizzaId = 8,
                                    AllergyInformation = "",
                                    CategoryId = 1,
                                    ImagePath = "~/Images/pizzas/veg-pizza.png",
                                    ImageThumbnailPath = "~/Images/thumbnails/veg-small.png",
                                    InStock = true,
                                    IsPizzaOfTheWeek = true,
                                    LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                                    Name = "Vegetarian Pizza",
                                    Price = 14.50m,
                                    ShortDescription = "We care about all!"
                                },
                                    new Pizza
                        {
                            PizzaId = 9,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImagePath = "~/Images/pizzas/pepperoni-pizza.png",
                            ImageThumbnailPath = "~/Images/thumbnails/pepperoni-small.png",
                            InStock = true,
                            IsPizzaOfTheWeek = true,
                            LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                            Name = "Pepparoni Chedder Pizza",
                            Price = 17.50m,
                            ShortDescription = "Have a party with this Pizza!"
                        },
                                        new Pizza
                        {
                            PizzaId = 10,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImagePath = "~/Images/pizzas/cheese-pizza.png",
                            ImageThumbnailPath = "~/Images/thumbnails/cheese-small.png",
                            InStock = true,
                            IsPizzaOfTheWeek = false,
                            LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                            Name = "Cheese Pizza",
                            Price = 16.00m,
                            ShortDescription = "Our famous Cheese Pizzas!"
                        },
                                            new Pizza
                        {
                            PizzaId = 11,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImagePath = "~/Images/pizzas/chicken-cheese-pizza.png",
                            ImageThumbnailPath = "~/Images/thumbnails/chicken-small.png",
                            InStock = true,
                            IsPizzaOfTheWeek = false,
                            LongDescription = "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.",
                            Name = "Chicken Trio Pizza",
                            Price = 18.95m,
                            ShortDescription = "3 Chickens made it!"

                        }
                                                 };

        public IEnumerable<Pizza> PizzasOfTheWeek { get; }

        public Pizza GetPizzaById(int PizzaId)
        {
            return AllPizzas.FirstOrDefault(p => p.PizzaId == PizzaId);
        }
    }
}
