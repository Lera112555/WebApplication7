using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data.IntFc;
using WebApplication7.Data.Models;

namespace WebApplication7.Data.mocks
{
    public class MockFlower : IAllFlowers
    {
        private readonly IFlowerCategory _categoryFlowers = new MockCategory(); 
        public IEnumerable<Flower> Flowers
        {
            get 
            {
                return new List<Flower>
                {
                    new Flower {name = "Эустома", shortDesk="", longDesc="", img="", price=500, isFavorite=true, availble=true, Category=_categoryFlowers.AllCategories.First()}
                };
            }
        } 
        public IEnumerable<Flower> getFavFlowers { get; set; }

        public Flower getObjectCar(int flowerId)
        {
            throw new NotImplementedException();
        }
    }
}
