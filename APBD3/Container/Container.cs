namespace APBD3.Conatiner;

public class Container : IContainer
{
    private double _cargoWeight;

   public double CargoWeight { get; set; }


   public Container(double cargoWeight)
   {
       _cargoWeight = cargoWeight;
   }


   public void Unload()
   {
       throw new NotImplementedException();
   }

   public void Load(double sad)
   {
       throw new OverfillException();
   }
}


