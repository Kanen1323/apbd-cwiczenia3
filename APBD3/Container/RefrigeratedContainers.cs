using APBD3.Interface;

namespace APBD3.Container;

public class RefrigeratedContainers : IContainer
{
    public int Weight { get; set; }
    public int Height { get; }
    public int WeightOfContainer { get; }
    public int Depth { get; }
    public int MaxWeight { get; }
    public string Type { get; }
    public string number { get; }
    private PossibleProducts _products { get; }
    private double _temperature;
    private static int _count ;

    public RefrigeratedContainers(double temperature, int weight, int height, int weightOfContainer, int depth, int maxWeight, PossibleProducts products)
    {
        _temperature = temperature;
        Weight = weight;
        Height = height;
        WeightOfContainer = weightOfContainer;
        Depth = depth;
        MaxWeight = maxWeight;
        _products = products;
        Type = "Refrigerated";
        number = NumberCreate(Type);
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
        Console.WriteLine(number + " The container is loaded. Current weight " + Weight + "kg " + _products);

    }

    public void print_information()
    {
        Console.WriteLine("Maximum container weight" + MaxWeight  + ". The container is loaded to " + Weight  + ". Container type " + Type + " .\n" + 
                          "Container height " + Height + " . Weight of the container itself " + WeightOfContainer + ". Container depth " + Depth  + ". Product "+ _products + " . Serial number of the container "  + number);

    }
    public void Loading(int weight, PossibleProducts products)
    {
        if (products!=_products)
            throw new ProductException("it is not possible to add a product to a container that already contains another product");

        else
        Loading(weight);
    }
}