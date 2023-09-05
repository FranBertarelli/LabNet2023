using System.Collections.Generic;
using System.Linq;

namespace Lq.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public CategoriesLogic() : base() { }

        public List<string> DifferentsCategories()
        {
            var distinctCategories = _context.Products
                .Select(product => product.Categories.CategoryName)
                .Distinct()
                .ToList();

            return distinctCategories;
        }
    }
}
