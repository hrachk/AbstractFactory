using AbstractFact.Abstracts;
using AbstractFactory.Abstracts;
using AbstractFactory.ProductsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    class PepsiFactory : AFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }

        public override AbstractWater CreateWatter()
        {
            return new PepsiWater();
        }
    }
}
