using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data.IntFc;
using WebApplication7.Data.Models;

namespace WebApplication7.Data.mocks
{
    public class MockCategory : IFlowerCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Полевые цветы", desc="Новинка"},
                    new Category {categoryName = "Кустовые цветы", desc="Новинка"}
                };

            }
        }
    }
}
