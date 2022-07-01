using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight.Model.Vehicle
{
    internal abstract class AVehicle
    {
        public string Make { get; private set; }

        public string Color { get; private set; }

        public string Id { get; }

        public abstract void SetDetails(string year, string owner);
    }
}
