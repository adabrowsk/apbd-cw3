using APBDcw3.Containers;

namespace APBDcw3;

public class Ship
{
    public List<Container> Containers { get; private set; }
    public double MaxSpeed { get; set; }
    public double MaxWeight { get; set; }
    public int MaxContainerCount { get; set; }

    public Ship(List<Container> containers, double maxSpeed, double maxWeight, int maxContainerCount)
    {
        Containers = containers;
        MaxSpeed = maxSpeed;
        MaxWeight = maxWeight;
        MaxContainerCount = maxContainerCount;
    }

    public bool AddContainer(Container container)
    {
        if (Containers.Count < MaxContainerCount)
        {
            Containers.Add(container);
            return true; //add some info about adding successfully
        }
        else
        {
            return false; //change to sth fancier or not, but add info about not adding
        }
    }
}