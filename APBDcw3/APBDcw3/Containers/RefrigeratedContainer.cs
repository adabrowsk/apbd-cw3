
using APBDcw3.Exceptions;

namespace APBDcw3.Containers;

public class RefrigeratedContainer : Container
{
    public double Temperature { get; set; }
    private ProductStored? currentProductStored = null;

    public RefrigeratedContainer(double cargoWeight, double height, double maxCapacity, bool isHazardous, double temperature, ProductStored productStored) : base(cargoWeight, height, maxCapacity, "R", isHazardous)
    {
        Temperature = temperature;
        currentProductStored = productStored;
    }
   
    public void SetProductStored(ProductStored product)
    {
        if (currentProductStored.HasValue && currentProductStored.Value != product)
        {
            throw new InvalidOperationException("This container is already storing a different type of product.");
        }
        
        if (!IsTemperatureSuitableForProduct(product))
        {
            throw new InvalidOperationException("The set temperature is not suitable for the selected product.");
        }

        currentProductStored = product;
    }
     private bool IsTemperatureSuitableForProduct(ProductStored product)
        {
            return CheckTemperature(product);
        }
    public override void Load(double cargoWeight)
    {
        if (!currentProductStored.HasValue)
        {
            throw new InvalidOperationException("Product type must be set before loading the container.");
        }
        
       
        if (CargoWeight + cargoWeight > MaxCapacity)
        {
            throw new OverfillException("Cargo weight exceeds maximum capacity.");
        }
        

        CargoWeight += cargoWeight;
        
    }
    private bool CheckTemperature(ProductStored productStored)
         {
             switch (productStored)
             {
                 case ProductStored.Banana:
                     return Temperature >= 13.3;
                 case ProductStored.Chocolate:
                     return Temperature >= 18;
                 case ProductStored.Fish:
                     return Temperature >= 2;
                 case ProductStored.Meat:
                     return Temperature >= -15;
                 case ProductStored.IceCream:
                     return Temperature >= -18;
                 case ProductStored.FrozenPizza:
                     return Temperature >= -30;
                 case ProductStored.Cheese:
                     return Temperature >= 7.2;
                 case ProductStored.Sausages:
                     return Temperature >= 5;
                 case ProductStored.Butter:
                     return Temperature >= 20.5;
                 case ProductStored.Eggs:
                     return Temperature >= 19;
                 default:
                     throw new ArgumentOutOfRangeException("Unknown product type.");
             }
         }

    public override void Unload()
    {
        base.Unload();
        currentProductStored = null;
    }
} 