using System.Security.AccessControl;
using APBDcw3.Exceptions;
using APBDcw3.Interfaces;

namespace APBDcw3.Containers;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double MaxCapacity { get; set; }
    public string SerialNumber { get; set; }
    
    protected Container(double cargoWeight, double height, double maxCapacity, string serialNumber)
    {
        CargoWeight = cargoWeight;
        Height = height;
        MaxCapacity = maxCapacity;
        SerialNumber = serialNumber;
    }

    public virtual void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        CargoWeight = cargoWeight;
        throw new OverfillException();
    }
}