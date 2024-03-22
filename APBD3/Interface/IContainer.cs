    namespace APBD3.Interface;

    public interface IContainer
    {

        int Weight { get; }
        int Height { get; }
     
         
        int WeightOfContainer { get; }
        int Depth { get; }
        
        int MaxWeight { get; }

        String Type { get;}

        String NumberCreate(String type);
        
        






    }