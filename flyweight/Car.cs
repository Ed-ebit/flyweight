using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public class Car : IVehicle  //actual flyweight object
    {
        public string Make { get; private set; }

        public string Color { get; private set; }

        public string Id  { get; }

        public Car(string make, string color, string id)
        {
            Make = make;
            Color = color;
            Id = id;
        }

        public void SetDetails(string year, string owner) // combines intrinsic and extrinsic data
                                                          // (or values) via Method
        {
            Console.WriteLine($"Year of production and current owner of Car: {Make} with Color: {Color} is {year}, {owner}");
        }
        //public void SetOwnership( bool IsSold){
        //    Console.WriteLine($"Car is already Sold: {IsSold}");
        //    }

    }
}
