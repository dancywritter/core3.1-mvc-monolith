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
                columns: new[] { "PizzaId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPizzaOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/applePizzasmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applePizza.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Apple Pizza", 12.95m, "Our famous apple Pizzas!" },
                    { 4, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryPizzasmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryPizza.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Cherry Pizza", 15.95m, "A summer classic!" },
                    { 7, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachPizzasmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachPizza.jpg", false, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Peach Pizza", 15.95m, "Sweet as peach" },
                    { 9, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbPizzasmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbPizza.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Rhubarb Pizza", 15.95m, "My God, so sweet!" },
                    { 10, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryPizzasmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryPizza.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Pizza", 15.95m, "Our delicious strawberry Pizza!" },
                    { 2, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Blueberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 3, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Cheese Cake", 18.95m, "Plain cheese cake. Plain pleasure." },
                    { 11, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", false, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 5, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplePizzasmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplePizza.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Christmas Apple Pizza", 13.95m, "Happy holidays with this Pizza!" },
                    { 6, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryPizzasmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryPizza.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Cranberry Pizza", 17.95m, "A Christmas favorite" },
                    { 8, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinPizzasmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinPizza.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.", "Pumpkin Pizza", 12.95m, "Our Halloween favorite" }
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
