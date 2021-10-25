using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        public List<Flower> flowers { get; set; }
    }
}
