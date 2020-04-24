using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace core3._1_mvc_monolith.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Spicy Pizzas" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Meat Pizzas" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Vegetarian Pizzas" });

            //seed Pizzas

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 1,
                Name = "Apple Pizza",
                Price = 12.95M,
                ShortDescription = "Our famous apple Pizzas!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = true,
                IsPizzaOfTheWeek = true,
                ImageThumbnailPath = "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 2,
                Name = "Blueberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = true,
                IsPizzaOfTheWeek = false,
                ImageThumbnailPath =
                    "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 3,
                Name = "Cheese Cake",
                Price = 18.95M,
                ShortDescription = "Plain cheese cake. Plain pleasure.",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = true,
                IsPizzaOfTheWeek = false,
                ImageThumbnailPath = "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 4,
                Name = "Cherry Pizza",
                Price = 15.95M,
                ShortDescription = "A summer classic!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = true,
                IsPizzaOfTheWeek = false,
                ImageThumbnailPath = "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 5,
                Name = "Christmas Apple Pizza",
                Price = 13.95M,
                ShortDescription = "Happy holidays with this Pizza!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = true,
                IsPizzaOfTheWeek = false,
                ImageThumbnailPath =
                    "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 6,
                Name = "Cranberry Pizza",
                Price = 17.95M,
                ShortDescription = "A Christmas favorite",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = true,
                IsPizzaOfTheWeek = false,
                ImageThumbnailPath = "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 7,
                Name = "Peach Pizza",
                Price = 15.95M,
                ShortDescription = "Sweet as peach",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = false,
                IsPizzaOfTheWeek = false,
                ImageThumbnailPath = "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 8,
                Name = "Pumpkin Pizza",
                Price = 12.95M,
                ShortDescription = "Our Halloween favorite",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = true,
                IsPizzaOfTheWeek = true,
                ImageThumbnailPath = "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 9,
                Name = "Rhubarb Pizza",
                Price = 15.95M,
                ShortDescription = "My God, so sweet!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = true,
                IsPizzaOfTheWeek = true,
                ImageThumbnailPath = "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 10,
                Name = "Strawberry Pizza",
                Price = 15.95M,
                ShortDescription = "Our delicious strawberry Pizza!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = true,
                IsPizzaOfTheWeek = false,
                ImageThumbnailPath = "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pizza>().HasData(new Pizza
            {
                PizzaId = 11,
                Name = "Strawberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Pizza chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Pizza muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Pizza cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImagePath = "~/Images/pizzas/cheese-pizza.png",
                InStock = false,
                IsPizzaOfTheWeek = false,
                ImageThumbnailPath =
                    "~/Images/pizzas/cheese-pizza.png",
                AllergyInformation = ""
            });
        }
    }
}
