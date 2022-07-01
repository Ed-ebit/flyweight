using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public class Boat : IVehicle
    {

        public string Make { get; private set; }

        public string Color { get; private set; }

        public string Id { get; }

        public Boat(string make, string color, string id)
        {
            Make = make;
            Color = color;
            Id = id;
        }

        public void SetDetails(string year, string owner)
        {
            Console.WriteLine($"Year of production and current owner of Boat: {Make} with Color: {Color} is {year}, {owner}\n");
        }
    }
}
