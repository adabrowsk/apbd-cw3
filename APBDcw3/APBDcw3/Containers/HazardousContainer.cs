using APBDcw3.Interfaces;

namespace APBDcw3.Containers;

public abstract class HazardousContainer : Container, IHazardNotifier
{
    protected HazardousContainer(double cargoWeight, double height, double maxCapacity, string serialNumber) : base(cargoWeight, height, maxCapacity, serialNumber)
    {
        //do hazardous containers require additional temperature handling? or sth
    }

    public virtual void NotifyHazard()
    {
        throw new NotImplementedException();
    }
}