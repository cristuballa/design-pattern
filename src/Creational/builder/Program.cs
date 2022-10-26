// See https://aka.ms/new-console-template for more information
Console.WriteLine("Builder Design Pattern");

var director=new Director();
var builder=new CarBuilder();
    director.MakeSUV(builder);
      Console.WriteLine(builder.Build());
    director.MakeSportsCar(builder);
  Console.WriteLine(builder.Build());