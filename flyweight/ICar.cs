using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public interface ICar
    {

        string Make { get; }
        string Color { get; }
        bool IsSold { get; }

        void SetLocation(decimal lat, decimal lng);
    }
}
