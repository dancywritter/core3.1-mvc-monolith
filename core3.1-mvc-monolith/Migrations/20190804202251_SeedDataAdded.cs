using Microsoft.EntityFrameworkCore.Migrations;

namespace core3._1_mvc_monolith.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Spicy Pizzas", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Meat Pizzas", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Vegetarian Pizzas", null });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "PizzaId", "AllergyInformation", "CategoryId", "ImageThumbnailPath", "ImagePath", "InStock", "IsPizzaOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "~/Images/pizzas/cheese-pizza.png", "~/Images/thumbnails/cheese-small.png", true, true, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Cheese Pizza", 12.95m, "Our famous Cheese Pizzas!" },
                    { 4, "", 1, "~/Images/pizzas/chicken-cheese-pizza.png", "~/Images/thumbnails/chicken-small.png", true, false, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Chicken Pizza", 15.95m, "A delicious one!" },
                    { 7, "", 1, "~/Images/pizzas/meat-pizza.png", "~/Images/thumbnails/meat-small.png", false, false, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Meat Pizza", 15.95m, "Best 4 meat lovers" },
                    { 9, "", 1, "~/Images/pizzas/pepperoni-pizza.png", "~/Images/thumbnails/pepperoni-small.png", true, true, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Pepperoni Pizza", 15.95m, "Can't say no to Pepperoni!" },
                    { 10, "", 1, "~/Images/pizzas/supreme-pizza.png", "~/Images/thumbnails/supreme-small.png", true, false, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Supreme Pizza", 15.95m, "Mix it all!" },
                    { 2, "", 2, "~/Images/pizzas/cheese-pizza.png", "~/Images/thumbnails/cheese-small.png", true, false, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Cheese Pizza", 18.95m, "You cant forget it!" },
                    { 3, "", 2, "~/Images/pizzas/chicken-cheese-pizza.png", "~/Images/thumbnails/chicken-small.png", true, false, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Chicken Trio Pizza", 18.95m, "3 Chickens made it" },
                    { 11, "", 2, "~/Images/pizzas/meat-pizza.png", "~/Images/thumbnails/meat-small.png", false, false, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Meat Lover Pizza", 18.95m, "If you love meat" },
                    { 5, "", 3, "~/Images/pizzas/pepperoni-pizza.png", "~/Images/thumbnails/pepperoni-small.png", true, false, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Pepparoni Chedder Pizza", 13.95m, "Have a party with this Pizza!" },
                    { 6, "", 3, "~/Images/pizzas/meat-pizza.png", "~/Images/thumbnails/meat-small.png", true, false, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Spicy Meat Pizza", 17.95m, "If you can handle spice" },
                    { 8, "", 3, "~/Images/pizzas/veg-pizza.png", "~/Images/thumbnails/veg-small.png", true, true, "In a glass or plastic bowl, combine yeast, water, and sugar (the water can just be water from the tap, make sure it's below 100°F). Stir to dissolve the yeast and let the yeast bloom for 15 minutes. Stir in 1 cup flour, add salt, and then stir in another cup of flour (the remaining cup of flour will be your bench flour and added flour). Dump mixture onto kneading board and work in last cup of flour, kneading until dough is soft and elastic, but not sticky. Form dough into a ball. In another bowl, pour in the 1 tbsp olive oil and spread around. Coat ball of dough with oil and cover bowl with a damp towel and let dough rise for 40 minutes.", "Vegetarian Pizza", 12.95m, "We respect all kind" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
