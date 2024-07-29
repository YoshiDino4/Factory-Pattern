using System;

namespace FactoryPattern;

    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = null;
            
            while (vehicle == null)
            {
                Console.WriteLine("Enter the number of tires on the vehicle:");
                if (int.TryParse(Console.ReadLine(), out int numberOfTires))
                {
                    vehicle = VehicleFactory.GetVehicle(numberOfTires);
                    if (vehicle == null)
                    {
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            vehicle.Drive();
        }
    }