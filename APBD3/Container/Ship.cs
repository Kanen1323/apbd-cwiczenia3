
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

  public Ship(int maxContainers, double maxWeight)
  {
    _maxContainers = maxContainers;
    _maxWeight = maxWeight;
  }

  public override string ToString()
  {
    return "Ship has " + _containers.Count + " containers with height " + Weight;
  }

  public void Loading()
  {

    foreach (var container in _containers)
    {
    
      if (Weight+container.Weight<_maxWeight)
      {
        Weight += container.Weight;
      }
      else
      {
        throw new ShipException();
      }
    }
    
    
  }
  
}