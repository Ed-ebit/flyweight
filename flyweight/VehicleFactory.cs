using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    public class VehicleFactory
    {
        private static readonly Lazy<VehicleFactory> instance = new Lazy<VehicleFactory>(() => new VehicleFactory());
        private Dictionary<string, IVehicle> vehicle = new Dictionary<string, IVehicle>();

        private VehicleFactory() { }// CarFactory is Singleton
        public static VehicleFactory GetInstance() { return instance.Value; } // CarFactory is Singleton

        public IVehicle GetVehicle(string make, string color)
        {
            string vehicleID = make + color;
            IVehicle? vehicle = null;
            if (this.vehicle.ContainsKey(vehicleID))
            {
                vehicle = this.vehicle[vehicleID];
                Console.WriteLine("Returning cached Model for Vehicle-Creation: {0}", vehicleID);
            }
            else
            {
                vehicle = new Car(make, color, vehicleID);
                this.vehicle.Add(vehicleID, vehicle);
                Console.WriteLine("Instanciating new Object for Vehicle-Creation: {0}", vehicleID);
            }
            return vehicle;
        }

        

    }
}
