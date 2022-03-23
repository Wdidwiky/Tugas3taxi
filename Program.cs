class Program
{
    static void Main(string[] args)
    {
        Taxi taxi = new Taxi();

        taxi.DriverName = "Jono";
        taxi.Onduty = true;
        taxi.NumPassenger = 10;

        taxi.TaxiInfo();
        taxi.PickUpPassenger();
        taxi.DropOffPassenger();

        Console.ReadKey();
    }
}
