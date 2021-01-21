using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
           new List<Category>
           {
               new Category{Category_ID=1, Description="lvklhfvdhfkvjhk", Name="djlvdkhdkgh"}
           };
    }
}
