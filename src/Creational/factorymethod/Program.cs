using DesignPatterns.Creational.factorymethod;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var factory = new ConcreteCreatorB();
var product = factory.CreateProduct();
product.DoStuff();
