using flyweight.Model.Vehicle;

namespace flyweight
{
    internal class VehicleFactory
    {
        interface 

        private static readonly Lazy<VehicleFactory> instance = new Lazy<VehicleFactory>(() => new VehicleFactory());
        private Dictionary<string, AVehicle> vehicle = new Dictionary<string, AVehicle>();

        private VehicleFactory() { }// CarFactory is Singleton
        public static VehicleFactory GetInstance() { return instance.Value; } // CarFactory is Singleton

        public AVehicle GetVehicle( AVehicle vehicle, string make, string color)
        {
            string vehicleID = make + color;
            if (this.vehicle.ContainsKey(vehicleID))
            {
                Console.WriteLine("Returning cached Model for Vehicle-Creation: {0}", vehicleID);
                return this.vehicle[vehicleID];
            }

            vehicle.SetDetails(make, color);

            this.vehicle.Add(vehicleID, vehicle);
            Console.WriteLine("Instanciating new Object for Vehicle-Creation: {0}", vehicleID);

            return vehicle;
        }
    }
}