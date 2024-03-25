using APBDcw3.Containers;
using System.Linq;
using System.Xml;

namespace APBDcw3.Logic;

public class Ship
{
    public List<Container> Containers { get; private set; } = new List<Container>(); 
    public double MaxSpeed { get; set; }
    public double MaxWeight { get; set; }
    public int MaxContainerCount { get; set; }

    public Ship(double maxSpeed, double maxWeight, int maxContainerCount)
    {
        MaxSpeed = maxSpeed;
        MaxWeight = maxWeight;
        MaxContainerCount = maxContainerCount;
        
    }
    
    public bool AddContainer(Container container)
    {
        if (Containers.Count >= MaxContainerCount)
        {
            Console.WriteLine("The ship is at maximum capacity.");
            return false; 
        }
       
        double totalWeightAfterAdding = CalculateTotalWeight() + container.CargoWeight;
        if (totalWeightAfterAdding > MaxWeight)
        {
            Console.WriteLine("The weight limit of the ship would be exceeded.");
            return false; 
        }

        Containers.Add(container);
        Console.WriteLine("Container added successfully.");
        return true;
    }
    
    public double CalculateTotalWeight()
    {
        return Containers.Sum(container => container.CargoWeight);
    }
    
    public bool RemoveContainer(string serialNumber)
    {
        var container = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container != null)
        {
            Containers.Remove(container);
            Console.WriteLine("Container removed successfully.");
            return true;
        }
        Console.WriteLine("Container not found.");
        return false;
    }

    //Load a list of containers onto the ship.
    public void LoadContainers(IEnumerable<Container> containers)
    {
        foreach (var container in containers)
        {
            AddContainer(container); 
        }
    }
    
    //Unload (empty) a container by serial number.
    public void UnloadContainer(string serialNumber)
    {
        var container = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        container?.Unload(); 
    }
    
    //Replace a container on the ship with another one by serial number.
    public bool ReplaceContainer(string serialNumber, Container newContainer)
    {
        var index = Containers.FindIndex(c => c.SerialNumber == serialNumber);
        if (index != -1)
        {
            Containers[index] = newContainer;
            return true;
        }
        return false;
    }
    
    // Transfer a container to another ship.
    public bool TransferContainerToShip(string serialNumber, Ship otherShip)
    {
        var container = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container != null && otherShip.AddContainer(container))
        {
            Containers.Remove(container);
            return true;
        }
        return false;
    }
    
    
    
}