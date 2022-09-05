using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidASP.Models.ViewModels
{
    public class BeerViewModel
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public string GetInfo() => Name + " " + Brand; 
    }
}
