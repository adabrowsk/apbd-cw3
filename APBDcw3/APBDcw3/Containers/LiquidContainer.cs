using APBDcw3.Exceptions;
using APBDcw3.Interfaces;

namespace APBDcw3.Containers;

public class LiquidContainer : HazardousContainer
{
    
    public LiquidContainer(double cargoWeight, double height, double maxCapacity, bool isHazardous) : base(cargoWeight, height, maxCapacity, "L", isHazardous)
    {
  
    }
    public override void Load(double cargoWeight)
    {
        double allowedCapacity = IsHazardous ? MaxCapacity * 0.5 : MaxCapacity * 0.9;

        if (CargoWeight + cargoWeight > allowedCapacity)
        {
            if (IsHazardous)
            {
                NotifyHazard($"Attempted to load {cargoWeight}kg of hazardous material which exceeds the allowed 50% capacity for {SerialNumber}.");
            }
            throw new OverfillException("Loading this cargo would exceed the container's allowed capacity.");
        }

        CargoWeight += cargoWeight;
    }

}