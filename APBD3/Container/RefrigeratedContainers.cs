using APBD3.Interface;

namespace APBD3.Container;

public class RefrigeratedContainers : IContainer
{
    public double Weight { get; set; }
    public int Height { get; }
    public int WeightOfContainer { get; }
    public int Depth { get; }
    public double MaxWeight { get; }
    public string Type { get; }
    public string number { get; }

    private Dictionary<PossibleProducts, double> _hashmap = new Dictionary<PossibleProducts, double>();
    private PossibleProducts Products { get; }
    private double _temperature;
    private static int _count ;

    public RefrigeratedContainers(double temperature, double weight, int height, int weightOfContainer, int depth, double maxWeight, PossibleProducts products)
    {
        Temperature();
        _temperature = temperature;
        Products = products;
        Weight = weight;
        Height = height;
        WeightOfContainer = weightOfContainer;
        Depth = depth;
        MaxWeight = maxWeight;
        Type = "Refrigerated";
        number = NumberCreate(Type);
        
        CheckTemperature();
        
    }


    public string NumberCreate(string type)
    {
        int id = _count;
        _count++;
        return "KON-C"  + "-" + id;
    }

    public void Emptying()
    {
        Weight = 0;
        Console.WriteLine("The container is unloaded");
    }

    public void Loading(int weight)
    {
        if (!(Weight+weight<MaxWeight))
            throw new OverfillException("Dangerous action someone tries to overfill the container");

        Weight += weight;
        Console.WriteLine(number + " The container is loaded. Current weight " + Weight + "kg " + Products);

    }

    public void print_information()
    {
        Console.WriteLine("Maximum container weight" + MaxWeight  + ". The container is loaded to " + Weight  + ". Container type " + Type + " .\n" + 
                          "Container height " + Height + " . Weight of the container itself " + WeightOfContainer + ". Container depth " + Depth  + ". Product "+ Products + " . Serial number of the container "  + number);

    }
    public void Loading(int weight, PossibleProducts products)
    {
        if (products!=Products)
            throw new ProductException("it is not possible to add a product to a container that already contains another product");
      
        Loading(weight);
    }



    public void Temperature()
    {
        _hashmap.Add(PossibleProducts.Bananas,13.3);
        _hashmap.Add(PossibleProducts.Chocolate,18);
        _hashmap.Add(PossibleProducts.Fish,2);
        _hashmap.Add(PossibleProducts.Meat,-15);
        _hashmap.Add(PossibleProducts.IceCream,-18);
        _hashmap.Add(PossibleProducts.FrozenPizza,-30);
        _hashmap.Add(PossibleProducts.Cheese,7.2);
        _hashmap.Add(PossibleProducts.Sausages,5);
        _hashmap.Add(PossibleProducts.Butter,20.5);
        _hashmap.Add(PossibleProducts.Eggs,19);
    }

    public void CheckTemperature()
    {
        foreach (var key in _hashmap.Keys)
        {
           
            if (key==Products)
            {
               
                if (!(_hashmap[key]-2<=_temperature && _hashmap[key]+2>=_temperature) )
                {
                    throw new TemperatureException(
                        "The temperature of your container differs by more than two degrees from the permissible temperature");
                }
            }
            
        }
    }
    
}