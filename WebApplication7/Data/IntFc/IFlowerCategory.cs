using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data.Models;

namespace WebApplication7.Data.IntFc
{
   public interface IFlowerCategory
    {
        IEnumerable<Category> AllCategories { get; }
    } 
}
