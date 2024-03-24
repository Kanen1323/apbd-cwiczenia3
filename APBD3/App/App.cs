using APBD3.Container;
using APBD3.Interface;

namespace APBD3.App;

public class App
{
    private static List<Ship> _ships = new List<Ship>();
    private static List<IContainer> _containers = new List<IContainer>();

    public void Start()
    {
        Console.WriteLine("Write what you want do");
        Console.WriteLine("1-Information about ships");
        Console.WriteLine("");
      
        
            switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("List of container ships:");
                for (int i = 0; i < _ships.Count; i++)
                {
                    Console.WriteLine(_ships[i].ToString());
                    
                }
                
            break;
        }
        
        
        
        
        
        
        
        
        
        
    }




}