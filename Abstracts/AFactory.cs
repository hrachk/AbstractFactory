using AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFact.Abstracts
{
    public abstract class AFactory
    {
        public abstract  AbstractWater CreateWatter();
        public abstract  AbstractBottle CreateBottle();

        public abstract AbstractCover CreateCover();
    }
}
