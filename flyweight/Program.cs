namespace flyweight
{
    public class Program
    {
        public static string arg;
        public static void Main(string[] args)
        {
            arg = args[0];
            VehicleFactory vehicleFactory = VehicleFactory.GetInstance();
            //Console.WriteLine("type 'boat' if you wish");
            //arg = Console.ReadLine();

            IVehicle car = vehicleFactory.GetVehicle("BMW", "gelb");
            car.SetDetails("1997", "Peter Hanssen");

            car = vehicleFactory.GetVehicle("BMW", "gelb");
            car.SetDetails("2008", "Frauke Schmidt");

            car = vehicleFactory.GetVehicle("Audi", "rot");
            car.SetDetails("2008", "Frauke Schmidt");
        }
    }
}