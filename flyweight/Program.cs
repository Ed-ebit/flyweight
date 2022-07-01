namespace flyweight
{
    public class Program
    {
        public static void Main()
        {
            VehicleFactory vehicleFactory = VehicleFactory.GetInstance();

            IVehicle car = vehicleFactory.GetCar("BMW", "gelb");
            car.SetDetails("1997", "Peter Hanssen");

            car = vehicleFactory.GetCar("BMW", "gelb");
            car.SetDetails("2008", "Frauke Schmidt");

            car = vehicleFactory.GetCar("Audi", "rot");
            car.SetDetails("2008", "Frauke Schmidt");
        }
    }
}