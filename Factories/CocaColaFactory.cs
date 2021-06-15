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
    class CocaColaFactory : AFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        } 

        public override AbstractWater CreateWatter()
        {
            return new CocaColaWater();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }
    }
}
