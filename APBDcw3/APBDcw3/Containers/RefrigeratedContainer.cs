
using APBDcw3.Exceptions;

namespace APBDcw3.Containers;

public class RefrigeratedContainer : Container
{
    public double Temperature { get; set; }

    public RefrigeratedContainer(double cargoWeight, double height, double maxCapacity, string serialNumber, double temperature) : base(cargoWeight, height, maxCapacity, serialNumber)
    {
        Temperature = temperature;
    }

    public override void Load(double cargoWeight)
    {
        // implement loading logic, respecting the temperature control and maximum capacity
        if (cargoWeight > MaxCapacity)
        {
            throw new OverfillException("Cargo weight exceeds maximum capacity.");
        }
        //include checks for specific temperature ranges based on the cargo type

        //CargoWeight = cargoWeight;
       

    }
    public void CheckTemperature()
         {
             
         }

    public override void Unload()
    {
        
    }
} 