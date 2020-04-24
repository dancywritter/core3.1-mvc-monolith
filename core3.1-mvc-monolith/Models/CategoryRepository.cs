using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core3._1_mvc_monolith.Models;

namespace core3._1_mvc_monolith.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;

    }
}
