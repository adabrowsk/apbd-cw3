namespace APBDcw3.Containers;

public class GasContainer : HazardousContainer
{
    public double Pressure { get; set; }
    public GasContainer(double cargoWeight, double height, double maxCapacity, string serialNumber, double pressure) : base(cargoWeight, height, maxCapacity, serialNumber)
    {
        Pressure = pressure;
    }

    public override void Load(double cargoWeight)
    {
        //add specifics
    }

    public override void NotifyHazard()
    {
        //add specifics
    }

    public override void Unload()
    {
        //add specifics
    }
}