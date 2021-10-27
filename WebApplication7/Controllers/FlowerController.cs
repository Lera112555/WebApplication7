using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Data.IntFc;
using WebApplication7.ViewModels;

namespace WebApplication7.Controllers
{
    public class FlowerController : Controller 
    { 
        private readonly IAllFlowers _allFlowers;
        private readonly IFlowerCategory _allCategories; 
        
        public FlowerController(IAllFlowers iAllFlowers, IFlowerCategory iFlowerCat)
        {
            _allFlowers = iAllFlowers;
            _allCategories = iFlowerCat; 
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с цветами"; 
            FlowerListViewModel obj = new FlowerListViewModel();
            obj.allFlowers = _allFlowers.Flowers;
            obj.flowerCategory = "Цветы"; 
            return View(obj); 
        }
    }
}
