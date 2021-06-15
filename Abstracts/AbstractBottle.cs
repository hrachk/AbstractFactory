using AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFact.Abstracts
{
    public abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
        public abstract void Interact(AbstractCover  cover);
    }
}
