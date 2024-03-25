using APBDcw3.Exceptions;

namespace APBDcw3.Containers;

public class GasContainer : HazardousContainer
{
    public double Pressure { get; set; }
    public GasContainer(double cargoWeight, double height, double maxCapacity,   bool isHazardous, double pressure) : base(cargoWeight, height, maxCapacity, "G", isHazardous)
    {
        Pressure = pressure;
    }

    public override void NotifyHazard()
    {
        Console.WriteLine($"Warning: Hazardous condition detected in container {SerialNumber}!");

    }

    public override void Unload()
    {
        CargoWeight *= 0.05;
    }
}