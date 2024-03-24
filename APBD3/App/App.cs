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
        Console.WriteLine("0-End Program");
        Console.WriteLine("1-I1nformation about ships");
        Console.WriteLine("2-Information about containers");
        Console.WriteLine("3-add Ship");
      
        
            switch (Console.ReadLine())
        {
            case "0":
                Console.WriteLine("Program End");
                break;
            case "1":
                Console.WriteLine("List of container ships:");
                for (int i = 0; i < _ships.Count; i++)
                {
                    Console.WriteLine(_ships[i].ToString());
                }
                Start();
            break;
            case "2":
                Console.WriteLine("List of container ships:");
                for (int i = 0; i < _ships.Count; i++)
                {
                    Console.WriteLine(_ships[i].ToString());
                }
                Start();
                break;
            case "3":
                Console.WriteLine("MaxConeiners");
                
                int containers = int.Parse(Console.ReadLine());
                Console.WriteLine("MaxWeight");
                int weight = int.Parse(Console.ReadLine());
                Ship ship = new Ship(containers, weight);
                _ships.Add(ship);
                Start();
                break;
            
            
            
            
            
        }
        
        
        
        
        
        
        
        
        
        
    }




}