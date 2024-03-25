/*
using APBDcw3.Containers;
using System;
using System.Collections.Generic;

namespace APBDcw3.Logic
{
    public class AppInterface
    {
        private readonly AppLogic appLogic;

        public AppInterface()
        {
            appLogic = new AppLogic();
            appLogic.CreateShip(20, 50000, 10);
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                appLogic.PrintShipInfo();
                Console.WriteLine("\nPossible actions:");
                Console.WriteLine("1. Add Container");
                Console.WriteLine("2. Remove Container");
                Console.WriteLine("3. Load Container onto Ship");
                Console.WriteLine("4. Create Ship (if not created)");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateAndAddContainer();
                        break;
                    case "2":
                        RemoveContainer();
                        break;
                    case "3":
                        LoadContainerOntoShip();
                        break;
                    case "4":
                        CreateShip();
                        break;
                    case "5":
                    case "exit":
                    case "Exit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        private void CreateAndAddContainer()
        {
            Console.WriteLine("Enter container type (L - Liquid, G - Gas, C - Refrigerated):");
            string containerType = Console.ReadLine().Trim().ToUpper();

            Console.WriteLine("Enter cargo weight:");
            double cargoWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter max capacity:");
            double maxCapacity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Is it hazardous? (yes/no)");
            bool isHazardous = Console.ReadLine().Trim().ToLower() == "yes";

            Container container = null;

            switch (containerType)
            {
                case "L":
                    container = appLogic.CreateLiquidContainer(cargoWeight, height, maxCapacity, isHazardous);
                    break;
                case "G":
                    Console.WriteLine("Enter pressure:");
                    double pressure = Convert.ToDouble(Console.ReadLine());
                    container = appLogic.CreateGasContainer(cargoWeight, height, maxCapacity, isHazardous, pressure);
                    break;
                case "C":
                    Console.WriteLine("Enter temperature:");
                    double temperature = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter product type (use corresponding enum value):");
                    ProductStored productStored = (ProductStored)Enum.Parse(typeof(ProductStored), Console.ReadLine());
                    container = appLogic.CreateRefrigeratedContainer(cargoWeight, height, maxCapacity, isHazardous,
                        temperature, productStored);
                    break;
                default:
                    Console.WriteLine("Invalid container type. Please enter 'L', 'G', or 'C'.");
                    return;
            }

            if (container != null)
            {
                appLogic.AddContainer(appLogic.Containers);
                Console.WriteLine("Container added.");
            }

            void RemoveContainer()
            {
                Console.WriteLine("Enter the serial number of the container to remove:");
                string serialNumber = Console.ReadLine();
                bool success = appLogic.RemoveContainer(serialNumber);
                if (success)
                {
                    Console.WriteLine("Container removed.");
                }
                else
                {
                    Console.WriteLine("Container not found.");
                }
            }

            void LoadContainerOntoShip()
            {
                if (!appLogic.IsShipCreated())
                {
                    Console.WriteLine("No ship available. Please create a ship first.");
                    return;
                }

                Console.WriteLine("Enter the serial number of the container to load onto the ship:");
                string serialNumber = Console.ReadLine();
                bool success = appLogic.LoadContainerOntoShip(serialNumber);
                if (success)
                {
                    Console.WriteLine("Container loaded onto the ship.");
                }
                else
                {
                    Console.WriteLine("Container not found or ship is at capacity.");
                }
            }

            void CreateShip()
            {
                if (appLogic.IsShipCreated())
                {
                    Console.WriteLine("Ship is already created.");
                    return;
                }

                Console.WriteLine("Enter max speed of the ship:");
                double maxSpeed = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter max weight of the ship:");
                double maxWeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter max container number for the ship:");
                int maxContainerCount = Convert.ToInt32(Console.ReadLine());

                appLogic.CreateShip(maxSpeed, maxWeight, maxContainerCount);
                Console.WriteLine("Ship created.");
            }
        }
    }
}
*/
