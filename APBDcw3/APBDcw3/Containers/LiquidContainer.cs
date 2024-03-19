namespace APBDcw3.Containers;

public class LiquidContainer : Container
{

    public LiquidContainer(double cargoWeight, double height, double maxCapacity, string serialNumber) : base(cargoWeight, height, maxCapacity, serialNumber)
        {
        }
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }

    
}