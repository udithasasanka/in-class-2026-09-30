using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public abstract class VehiclePrototype
    {
        public string engine, model, price, color;

        public VehiclePrototype(string engine, string model, string price, string color)
        {
            this.engine = engine;
            this.model = model;
            this.price = price;
            this.color = color;
        }

        public abstract VehiclePrototype Clone();
        public abstract void Display();
    }
}
