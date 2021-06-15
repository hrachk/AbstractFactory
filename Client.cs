using AbstractFact.Abstracts;
using AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFact
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractCover cover;
         
        public Client(AFactory factory)
        {
            water = factory.CreateWatter();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
        }

        public void Run()
        {
            bottle.Interact(water);
            bottle.Interact(cover);
             
        }
    }
}
