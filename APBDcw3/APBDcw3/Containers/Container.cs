using System.Security.AccessControl;
using APBDcw3.Exceptions;
using APBDcw3.Interfaces;

namespace APBDcw3.Containers;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double MaxCapacity { get; set; }
    public string SerialNumber { get; private set; }
    
    private static int _serialNumberCounter = 0;
    
    private bool _isHazardous;
    public bool IsHazardous => _isHazardous;
    
    public static string GenerateSerialNumber(string containerType)
    {
        return $"KON-{containerType}-{++_serialNumberCounter}";
    }
    protected Container(double cargoWeight, double height, double maxCapacity, string containerType, bool isHazardous)
    {
        CargoWeight = cargoWeight;
        Height = height;
        MaxCapacity = maxCapacity;
        SerialNumber = GenerateSerialNumber(containerType);
        _isHazardous = isHazardous;
    }

    public virtual void Unload()
    {
        CargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (CargoWeight + cargoWeight > MaxCapacity)
        {
            throw new OverfillException("Adding this cargo would exceed the container's maximum capacity.");
        }

        CargoWeight += cargoWeight;
    }
    
}
