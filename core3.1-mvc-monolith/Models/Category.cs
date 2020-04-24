using System.Collections.Generic;

namespace core3._1_mvc_monolith.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}
