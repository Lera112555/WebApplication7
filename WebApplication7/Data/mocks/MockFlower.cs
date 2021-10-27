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
                    new Flower
                    {name = "Эустома",
                        shortDesk="Красивая",
                        longDesc="Очень красивая",
                        img="https://yandex.ru/images/search?text=%D1%8D%D1%83%D1%81%D1%82%D0%BE%D0%BC%D0%B0%20%D0%B1%D1%83%D0%BA%D0%B5%D1%82%D1%8B&from=tabbar&pos=38&img_url=https%3A%2F%2Fpbs.twimg.com%2Fmedia%2FDV6OCZpW4AA59ik.jpg&rpt=simage",
                        price=500,
                        isFavorite=true,
                        availble=true,
                        Category=_categoryFlowers.AllCategories.First()
                    }, 
                    new Flower
                    { name = "Гипсофила",
                        shortDesk="Красивая",
                        longDesc="Очень красивая",
                        img="https://yandex.ru/images/search?text=ubgcjabkf%20&from=tabbar&pos=2&img_url=https%3A%2F%2Fstatic.tildacdn.com%2Ftild6536-3931-4562-a562-643638353865%2F7__.jpg&rpt=simage",
                        price=500,
                        isFavorite=true,
                        availble=true,
                        Category=_categoryFlowers.AllCategories.First()
                    },
                    new Flower
                    { name = "Пионы", 
                    shortDesk="12/10", 
                    longDesc="миллион из десяти", 
                    img="https://yandex.ru/images/search?text=%D0%BF%D0%B8%D0%BE%D0%BD%D1%8B%20%D0%B1%D1%83%D0%BA%D0%B5%D1%82&from=tabbar&p=2&pos=93&rpt=simage&img_url=https%3A%2F%2Fscontent-hel3-1.cdninstagram.com%2Fv%2Ft51.2885-15%2Fe35%2Fs1080x1080%2F104496501_2671987719724548_3675068786452455930_n.jpg%3Ftp%3D1%26_nc_ht%3Dscontent-hel3-1.cdninstagram.com%26_nc_cat%3D100%26_nc_ohc%3DcmcwBS83rK0AX9j0qXi%26edm%3DAABBvjUBAAAA%26ccb%3D7-4%26oh%3Da8acbd10818b4f867989c15f341206a8%26oe%3D60B892EC%26_nc_sid%3D83d603", 
                    price=700, 
                    isFavorite=true, 
                    Category=_categoryFlowers.AllCategories.First()

                    }   
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
