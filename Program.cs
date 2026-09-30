using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoWheelerVehicle t1 = new TwoWheelerVehicle("150cc", "Yamaha R15", "$2000", "Red", "Petrol");
            t1.Display();
            TwoWheelerVehicle t2 = (TwoWheelerVehicle)t1.Clone();
            t2.Display();

            FourWheelerVehicle f1 = new FourWheelerVehicle("2000cc", "Toyota Camry", "$25000", "Black", "Petrol", "Automatic");
            f1.Display();
            FourWheelerVehicle f2 = (FourWheelerVehicle)f1.Clone();
            f2.color = "Blue";
            f2.Display();

            FourWheelerVehicle f3 = new FourWheelerVehicle("3000cc", "Honda Accord", "$30000", "White", "Diesel", "Manual");
            f3.engine = "1800";
            f3.Display();

        }
    }
}
