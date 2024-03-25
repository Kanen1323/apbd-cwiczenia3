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
        Console.WriteLine("1-Information about ships");
        Console.WriteLine("2-Information about containers");
        Console.WriteLine("3-Add Ship");
        Console.WriteLine("4-Create standard container");
        Console.WriteLine("5-Delete Container");
        Console.WriteLine("6-Add some in container");
        
        
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
                for (int i = 0; i < _containers.Count; i++)
                {
                    Console.WriteLine(_containers[i].ToString());
                }
                Start();
                break;
            case "3":
               CreateShip();
                Start();
                break;
            case "4":
              CreateContainer();
              Start();
            break;
            case "5":
           DeleteCOntainer();
                Start();
                break;
            case "6":
               LoadingShip();
                break;

        }
            


    }


    public void CreateLiquid(double weight, int height, int weightOfContainer, int depth,double  maxWeight)
    {
        
    
            Console.WriteLine("choice which type of Liquid");
            Console.WriteLine("1-Milk");
            Console.WriteLine("2-Petrol");
            string typeLiquid = Console.ReadLine();
            if (typeLiquid=="1")
            {
                _containers.Add(new LiquidContainer(weight,height,weightOfContainer,depth,maxWeight,Liquid.Milk));
            }
            else
            {
                _containers.Add(new LiquidContainer(weight,height,weightOfContainer,depth,maxWeight,Liquid.Petrol));
            }
                
        

        
        
    }

    public void CreateGas(double weight, int height, int weightOfContainer, int depth, double maxWeight,int subjectOfPressure )
    {
        _containers.Add(new GasContainer(weight,height,weightOfContainer,depth,maxWeight,subjectOfPressure));
    }

    public void CreateRefrigerated(double weight, int height, int weightOfContainer, int depth, double maxWeight)
    {

        PossibleProducts selectedProduct= PossibleProducts.Bananas;
        double temperature=0;

        Console.WriteLine("1 - Bananas");
        Console.WriteLine("2 - Chocolate");
        Console.WriteLine("3 - Fish");
        Console.WriteLine("4 - Meat");
        Console.WriteLine("5 - IceCream");
        Console.WriteLine("6 - FrozenPizza");
        Console.WriteLine("7 - Cheese");
        Console.WriteLine("8 - Sausages");
        Console.WriteLine("9 - Butter");
        Console.WriteLine("10 - Eggs");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                selectedProduct = PossibleProducts.Bananas;
                temperature = 13.3;
                break;
            case "2":
                selectedProduct = PossibleProducts.Chocolate;
                temperature = 18;
                break;
            case "3":
                selectedProduct = PossibleProducts.Fish;
                temperature = 2;
                break;
            case "4":
                selectedProduct = PossibleProducts.Meat;
                temperature = -15;
                break;
            case "5":
                selectedProduct = PossibleProducts.IceCream;
                temperature = -18;
                break;
            case "6":
                selectedProduct = PossibleProducts.FrozenPizza;
                temperature = -30;
                break;
            case "7":
                selectedProduct = PossibleProducts.Cheese;
                temperature=7.2;
                break;
            case "8":
                selectedProduct = PossibleProducts.Sausages;
                temperature = 5;
                break;
            case "9":
                selectedProduct = PossibleProducts.Butter;
                temperature = 20.5;
                break;
            case "10":
                selectedProduct = PossibleProducts.Eggs;
                temperature = 19;
                break;

        }
        _containers.Add(new RefrigeratedContainers(temperature,weight,height,weightOfContainer,depth,maxWeight,selectedProduct));
    }

    public void CreateShip()
    {
        
        Console.WriteLine("MaxConeiners");
                
        int maxConeiners = int.Parse(Console.ReadLine());
        Console.WriteLine("MaxWeight");
        int maxWeight = int.Parse(Console.ReadLine());
        Ship ship = new Ship(maxConeiners, maxWeight);
        _ships.Add(ship);
        
    }

    public void DeleteCOntainer()
    {
            Console.WriteLine("Write number for delete");
            string number = Console.ReadLine();
        IContainer container= _containers[int.Parse(number)];
        _containers.RemoveAt(int.Parse(number));  
        Console.WriteLine("Container " + container.number + " was deleted");
        
    }

    public void CreateContainer()
    {
        Console.WriteLine("Which type of container?");
        Console.WriteLine("1-Liquid");
        Console.WriteLine("2-Gas");
        Console.WriteLine("3-Refrigreted");
        string choice = Console.ReadLine();
        if (choice=="1")
        {
            CreateLiquid(100,100,0,80,100);
        }else if (choice=="2")
        {
            CreateGas(100,100,0,80,100,20);
        }
        else
        {
            CreateRefrigerated(100,100,0,80,100);
        }
               
        
        
    }

    public void LoadingShip()
    {
        Console.WriteLine("Write number for delete");
        string number = Console.ReadLine();
        for (int i = 0; i < _containers.Count; i++)
        {
            _ships[int.Parse(number)].Add(_containers[i]);
        }
    }
    
}