using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbcontext;
        public CategoryRepository ( AppDbContext appDbContext )
        {
            _appDbcontext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => _appDbcontext.Category;
    }
}

