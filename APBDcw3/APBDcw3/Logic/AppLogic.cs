using APBDcw3;
using APBDcw3.Containers;
using APBDcw3.Exceptions;
using APBDcw3.Logic;
namespace APBDcw3.Logic;

public class AppLogic
{
    public Ship Ship { get; private set; }
    public List<Container> Containers { get; private set; } = new List<Container>();

    public bool IsShipCreated()
    {
        return Ship != null;
    }
    public AppLogic()
    {
    
    }
    // Method to create a ship if needed
    public void CreateShip(double maxSpeed, double maxWeight, int maxContainerCount)
    {
        if (Ship == null)
        {
            Ship = new Ship(maxSpeed, maxWeight, maxContainerCount);
            Console.WriteLine("Ship created successfully.");
        }
        else
        {
            Console.WriteLine("A ship has already been created.");
        }
    }

    public void AddContainerToShip(Container container)
    {
        if (Ship == null)
        {
            Console.WriteLine("No ship created. Create a ship before adding containers.");
        }
        else
        {
            Ship.AddContainer(container);
        }
    }


public Container CreateLiquidContainer(double cargoWeight, double height, double maxCapacity, bool isHazardous)
{
    string serialNumber = Container.GenerateSerialNumber("L");
    return new LiquidContainer(cargoWeight, height, maxCapacity, isHazardous);
}

public Container CreateGasContainer(double cargoWeight, double height, double maxCapacity, bool isHazardous,
    double pressure)
{
    string serialNumber = Container.GenerateSerialNumber("G");
    return new GasContainer(cargoWeight, height, maxCapacity, isHazardous, pressure);
}

public Container CreateRefrigeratedContainer(double cargoWeight, double height, double maxCapacity, bool isHazardous,
    double temperature, ProductStored productStored)
{
    string serialNumber = Container.GenerateSerialNumber("C");
    return new RefrigeratedContainer(cargoWeight, height, maxCapacity, isHazardous, temperature,
        productStored);
}


// Method that prints detailed information about the ship and its containers.
public void PrintShipInfo()
{
    Console.WriteLine($"Ship Details:");
    Console.WriteLine($"- Max Speed: {Ship.MaxSpeed} knots");
    Console.WriteLine($"- Max Weight: {Ship.MaxWeight} tons");
    Console.WriteLine($"- Max Container Count: {Ship.MaxContainerCount}");
    Console.WriteLine($"- Current Container Count: {Ship.Containers.Count}");
    Console.WriteLine($"- Total Cargo Weight: {Ship.CalculateTotalWeight()} kg");

    // Check if there are containers to display info for
    if (Containers.Any())
    {
        Console.WriteLine("Container Details:");
        foreach (var container in Containers)
        {
           
            PrintContainerInfo(container);
        }
    }
    else
    {
        Console.WriteLine("No containers on ship.");
    }
}
    
//Print info about a single container.
private void PrintContainerInfo(Container container)
{
    Console.WriteLine($"- Container Serial: {container.SerialNumber}, Weight: {container.CargoWeight} kg, Height: {container.Height} cm");
   
}


}

