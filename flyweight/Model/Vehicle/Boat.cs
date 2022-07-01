namespace flyweight.Model.Vehicle
{
    internal class Boat : AVehicle
    {
        public override void SetDetails(string year, string owner)
        {
            Console.WriteLine($"Year of production and current owner of Boat: {Make} with Color: {Color} is {year}, {owner}\n");
        }
    }
}
