    using APBD3.Container;

    namespace APBD3.Interface;

    public interface IContainer
    {

       int Weight { get; set; }
        int Height { get; }
     
         
        int WeightOfContainer { get; }
        int Depth { get; }
        
        int MaxWeight { get; }

        String Type { get;}
        String number { get;}

        String NumberCreate(String type);


        void Emptying();

        void Loading(int weight);

        void print_information();








    }