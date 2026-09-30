using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class FourWheelerVehicle : VehiclePrototype
    {
        public string transmission;

        public FourWheelerVehicle(string engine, string model, string price, string color, string fuel,string transmission) : base(engine, model, price, color)
        { 
            this.transmission = transmission;   
        }

        public override VehiclePrototype Clone()
        {
            return new FourWheelerVehicle(this.engine, this.model, this.price, this.color, this.fuel, this.transmission);
        }

        public override void Display()
        {
            Console.WriteLine($"Four-Wheeler Vehicle - Engine: {this.engine}, Model: {this.model}, Price: {this.price}, Color: {this.color}, Fuel: {this.fuel}, Transmission: {this.transmission}");
        }
    }
}
