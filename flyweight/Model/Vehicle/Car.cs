using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight.Model.Vehicle
{
    internal class Car : AVehicle
    {

        public override void SetDetails(string year, string owner)
        {
            Console.WriteLine($"Year of production and current owner of Car: {Make} with Color: {Color} is {year}, {owner}\n");
        }
    }
}
