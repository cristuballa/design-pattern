// See https://aka.ms/new-console-template for more information
Console.WriteLine("Facade Design Pattern");
    Subsystem1 subsystem1 = new Subsystem1();
    Subsystem2 subsystem2 = new Subsystem2();
    Facade facade = new Facade(subsystem1, subsystem2);
    Client.ClientCode(facade);
