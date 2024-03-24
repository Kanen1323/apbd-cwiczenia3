
using APBD3.Interface;

namespace APBD3.Container;

public  class Ship
{
  private List<IContainer> _containers;

  public Ship(List<IContainer> containers, int maxContainers, double maxWeight)
  {
    _containers = containers;
    _maxContainers = maxContainers;
    _maxWeight = maxWeight;
  }

  private int _maxContainers;
  private double _maxWeight;
  private double Weight;
  private int number;

  public Ship(int maxContainers, double maxWeight)
  {
    _maxContainers = maxContainers;
    _maxWeight = maxWeight;
    number++;
  }

  public override string ToString()
  {
   
    if (_containers !=null)
    {
     
      return "Ship has " + _containers.Count + " containers with height " + Weight;
    }
    else
    {
  3
      return "Ship " + number + " are free";
    }

  }

  public void Loading()
  {


    if (_maxContainers < _containers.Count)
      throw new ShipException("You have loaded the maximum number of containers");

    foreach (var container in _containers)
    {
    
      if (Weight+container.Weight<_maxWeight*1000)
      {
        Weight += container.Weight;
      }
      else
      {
        throw new ShipException();
      }
    }
    
  }

  public void Add(IContainer container)
  {
    
    if (Weight+container.Weight<_maxWeight)
    {
      Weight += container.Weight;
    }
    else
    {
      throw new ShipException();
    }
    _containers.Add(container);
    
  }
  
}