using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data.Models;

namespace WebApplication7.ViewModels
{
    public class FlowerListViewModel
    {
        public IEnumerable<Flower> allFlowers { get; set; }
        public string flowerCategory { get; set; }
    }
}
