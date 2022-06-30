using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public class CarFactory
    {
        private readonly IDictionary<string, ICar> cars = new Dictionary<string, ICar>();

        public ICar GetCar(string type)
        {
            return null;
        }

        private ICar CreateCar()
        {
            new Car(string make, string color, bool isSold);
        }

    }
}
