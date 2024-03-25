using APBDcw3.Interfaces;

namespace APBDcw3.Containers;

public abstract class HazardousContainer : Container, IHazardNotifier
{
    protected HazardousContainer(double cargoWeight, double height, double maxCapacity,  string containerType, bool isHazardous) : base(cargoWeight, height, maxCapacity, containerType, isHazardous)
    {
    }

    public virtual void NotifyHazard()
    {
        throw new NotImplementedException();
    }
    
    public virtual void NotifyHazard(string message)
    {
        throw new NotImplementedException();
    }
}