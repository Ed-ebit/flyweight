using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public interface IVehicle
    {

        //string Make { get; }
        //string Color { get; }
        //bool IsSold { get; }

        void SetDetails(string year, string owner); 
    }
}
