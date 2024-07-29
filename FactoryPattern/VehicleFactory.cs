namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfWheels)
        {
            switch (numberOfWheels)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                default:
                    Console.WriteLine("Sorry! This factory only makes Cars and Motorcycles!");
                    return null;
            }
        }
    }
}