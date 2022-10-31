// See https://aka.ms/new-console-template for more information
Console.WriteLine("**Adapter design pattern**");

var adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine($"Message from adaptee ->{target.GetRequest()}");