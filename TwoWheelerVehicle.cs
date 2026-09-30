using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class TwoWheelerVehicle : VehiclePrototype
    {
        public string fuel;

        public TwoWheelerVehicle(string engine, string model, string price, string color, string fuel) : base(engine, model, price, color)
        {
            this.fuel = fuel;
        }

        public override VehiclePrototype Clone()
        {
            return new TwoWheelerVehicle(this.engine, this.model, this.price, this.color, this.fuel);//this not mandatory
        }

        public override void Display()
        {
            Console.WriteLine($"Two-Wheeler Vehicle - Engine: {this.engine}, Model: {this.model}, Price: {this.price}, Color: {this.color}, Fuel: {this.fuel}");
        }
    }
}
