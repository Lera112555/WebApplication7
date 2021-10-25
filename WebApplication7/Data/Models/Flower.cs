using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Data.Models
{
    public class Flower
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesk { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; } 
        public ushort price { get; set; } 
        public bool isFavorite { get; set; }
        public bool availble { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; } 
    }
}
