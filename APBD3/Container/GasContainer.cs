using APBD3.Interface;

namespace APBD3.Container;

public class GasContainer : IContainer, IHazardNotifier
{
    public GasContainer(int weight, int height, int weightOfContainer, int depth, int maxWeight, int subjectOfPressure)
    {
        Weight = weight;
        Height = height;
        WeightOfContainer = weightOfContainer;
        Depth = depth;
        MaxWeight = maxWeight;
        SubjectOfPressure = subjectOfPressure;
         Type = "Gaz";
        number = NumberCreate(Type);
    }

    public double Weight { get; set; }
    public int Height { get; }
    public int WeightOfContainer { get; }
    public int Depth { get; }
    public int MaxWeight { get; }
    public string Type { get; }
    public string number { get; }
    private int _count;
   private int SubjectOfPressure { get; }
    public string NumberCreate(string type)
    {
        int id = _count;
        _count++;
        return "KON-" + type[0] + "-" + id;
    }

    public void Emptying()
    {
        Weight = Weight / 100 * 5;
        if (Weight>0)
            Console.WriteLine("The container has been unloaded, but it seems there is still some gas in it");
        else
            Console.WriteLine("The container is unloaded ");
            
        
       
      
    }

    public void Loading(int weight)
    {
        if (!(Weight+weight<MaxWeight))
           SendNotification("Dangerous action someone tries to overfill the container");

        Weight += weight;

    }

    public void SendNotification(string message)
    {
        throw new OverfillException(message);
    }
    
    
    public void print_information()
    {
        Console.WriteLine("Maximum container weight" + MaxWeight  + ". The container is loaded to " + Weight  + ". Container type " + Type + " .\n " +
                          "Container height " + Height + " . Weight of the container itself " + WeightOfContainer + ". Container depth " + Depth  + " . Serial number of the container "  + number + " Subject of pressure "  + SubjectOfPressure);
        
        
    }
    
}