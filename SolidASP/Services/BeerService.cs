using SolidASP.Models.BBDD;
using SolidASP.Models.ViewModels;
using SolidASP.Utils;

namespace SolidASP.Services
{
    public class BeerService
    {
        public void Create(BeerViewModel beer)
        {
            var beerDB = new BeerBBDD();
            var log = new Log();

            beerDB.Save(beer);
            log.Save("Guardamos la cerveza: " + beer.GetInfo());
        }
    }
}
