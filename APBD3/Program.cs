// See https://aka.ms/new-console-template for more information

using APBD3.Container;

LiquidContainer container1 = new LiquidContainer(100, 100, 100, 100, 1000,Liquid.Milk);
LiquidContainer container2 = new LiquidContainer(100, 100, 100, 100, 1000,Liquid.Petrol);
LiquidContainer container3 = new LiquidContainer(100, 100, 100, 100, 10000,Liquid.Milk);

Console.WriteLine(container1.number);
Console.WriteLine(container2.number);
Console.WriteLine(container3.number);
container1.Loading(100);
container1.print_information();




RefrigeratedContainers possibleProducts =
    new RefrigeratedContainers(12, 100, 100, 100, 1000, 1000, PossibleProducts.Bananas);

possibleProducts.Loading(100,PossibleProducts.Bananas);