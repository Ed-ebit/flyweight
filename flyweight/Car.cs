using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public class Car : ICar
    {
        public string Make {get; private set;}

        public string Color { get; private set; }

        public bool IsSold { get; private set; }

        public Car(string make, string color, bool isSold)
        {
            Make = make;
            Color = color;
            IsSold = isSold;
        }

        public void SetLocation(decimal lat, decimal lng)
        {
            Console.WriteLine($"Location of Car: {Make} with Color: {Color} is {lat}, {lng}\n" +
                $"Car is already sold: {IsSold}");
        }
    }
}
