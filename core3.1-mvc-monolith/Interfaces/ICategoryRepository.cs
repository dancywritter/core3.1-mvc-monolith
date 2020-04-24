using System.Collections.Generic;

namespace core3._1_mvc_monolith.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
