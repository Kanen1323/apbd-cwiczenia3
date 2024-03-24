using APBD3.Interface;
using IContainer = APBD3.Interface.IContainer;


namespace APBD3.Container;

public class LiquidContainer : IContainer, IHazardNotifier
{
   public double Weight { get;set; }
    public int Height { get;  }
    public int WeightOfContainer { get; }
    public int Depth { get; }
    public double MaxWeight { get; }
    public string Type { get; }
    public  String number { get;}
    
    private static int _count ;

    private static Liquid _liquid;
    private bool _dangerous;

    public LiquidContainer(double weight, int height, int weightOfContainer, int depth,double  maxWeight, Liquid liquid)
    {
        Weight = weight;
        Height = height;
        WeightOfContainer = weightOfContainer;
        Depth = depth;
        MaxWeight = maxWeight;
        Type = "Liquid";
        number = NumberCreate(Type);
        _liquid = liquid;
        _dangerous = Hazardousness();
    }

    public string NumberCreate(string type)
    {
        int id = _count;
        _count++;
        return "KON-" + type[0] + "-" + id;
    }

    public void Emptying()
    {
        Weight = 0;
        Console.WriteLine("The container is unloaded");


    }

   

    public void Loading(int weight)
    {


        
        if (!(Weight+weight<=MaxWeight))
            throw new OverfillException();

        if (_dangerous)
        {
            if (Weight+weight>=MaxWeight/2.0)
            {
                SendNotification("Is trying to perform an unsafe action for the container number " + number + ". Someone wants to fill the container with hazardous substances by more than 50%");
                return;

            }
        } 
        else
        {
            if (Weight+weight>=MaxWeight-MaxWeight/2.0)
            {
                SendNotification("Is trying to perform an unsafe action for the container number " + number + ". Someone wants to fill the container with substances by more than 90%");
                return;

            } 
        }
        
        Weight += weight;
        Console.WriteLine("The container is loaded. Current weight " + Weight + "kg");
    }

    public void SendNotification(string message)
    {
        
        throw new OverfillException(message);
    }

 bool Hazardousness()
    {
        if (_liquid==Liquid.Petrol)
        {
            return true;
        }

        return false;

    }

    public void print_information()
    {
        Console.WriteLine("Maximum container weight" + MaxWeight  + ". The container is loaded to " + Weight  + ". Container type " + Type + " .\n" + 
                            "Container height " + Height + " . Weight of the container itself " + WeightOfContainer + ". Container depth " + Depth  + " . Serial number of the container "  + number);
        
        
    }

    public override string ToString()
    {
        return "Maximum container weight" + MaxWeight  + ". The container is loaded to " + Weight  + ". Container type " + Type + " .\n" + 
               "Container height " + Height + " . Weight of the container itself " + WeightOfContainer + ". Liquid " + _liquid +". Container depth "
               + Depth  + " . Serial number of the container "  + number;
    }
}
