using SolidASP.Models.ViewModels;

namespace SolidASP.Models.BBDD
{
    public class BeerBBDD
    {
        public void Save(BeerViewModel beer)
        {
            Console.WriteLine("Guardamos en BBDD" + beer.Name);
        }
    }
}
