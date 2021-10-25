using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data.Models;

namespace WebApplication7.Data.IntFc
{
    public interface IAllFlowers
    {
        IEnumerable<Flower> Flowers { get; }
        IEnumerable<Flower> getFavFlowers { get; set; }
        Flower getObjectCar(int flowerId); 
    }
} 
