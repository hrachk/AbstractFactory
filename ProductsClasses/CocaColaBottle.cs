using AbstractFact.Abstracts;
using AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ProductsClasses
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this +"  Interact with  " + water);
        }

        public override void Interact(AbstractCover cover)
        {
            Console.WriteLine(this + "  Interact with  " + cover);
        }
    }
}
