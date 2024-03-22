    namespace APBD3;

    public interface IContainer
    {

        int Weight { get; }
        int Height { get; }
     
         
        int Weight_Of_Container { get; }
        int Depth { get; }
        
        int Max_Weight { get; }

        String type { get; }

        String NumberCreate(String type);
        
        






    }