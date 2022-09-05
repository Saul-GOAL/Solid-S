using System;

namespace Solid_S
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }

            public Beer(string Name, string Brand)
            {
                this.Name = Name;
                this.Brand = Brand;
            }

        }

        public class BeerDB
        {
            private Beer _beer;
            public BeerDB(Beer beer)
            {
                _beer = beer;
            }
            public void Save()
            {
                Console.WriteLine($"Guardamos {_beer.Name} y {_beer.Brand}");
            }
        }

        public class BeerRequest
        {
            private Beer _beer;
            public BeerRequest(Beer beer)
            {
                _beer = beer;
            }
            public void Send()
            {
                Console.WriteLine($"Enviamos a ese otro lugar {_beer.Name} y {_beer.Brand}");
            }
        }
    }


   

  
}