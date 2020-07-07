using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            var juansCar = new Car() {Year=2021 , Make="Ford" , Model="Explorer" };
            var juansMotorcycle = new Motorcycle() { Year = 2019, Make = "Harley", Model = "Kt500" };
            Vehicle juanOneVehicle = new Car() { Year = 2017, Make = "Toyota", Model = "Camry" };
            Vehicle juanTwoVehicle = new Motorcycle() { Year = 2015, Make = "Honda", Model = "Ninja300" };

            vehicles.Add(juansCar);
            vehicles.Add(juansMotorcycle);
            vehicles.Add(juanOneVehicle);
            vehicles.Add(juanTwoVehicle);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"My {vehicle.Model} it's mark is {vehicle.Make} and it is of {vehicle.Year}");
            }

            juansCar.DriveAbstract();
            juansCar.DriveVirtual();
            juansMotorcycle.DriveAbstract();
            juansMotorcycle.DriveVirtual();
            juanOneVehicle.DriveAbstract();
            juanOneVehicle.DriveVirtual();
            juanTwoVehicle.DriveAbstract();
            juanTwoVehicle.DriveVirtual();






            /*
             * Todo follow all comments!! 
             */

            #region Vehicles



            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
