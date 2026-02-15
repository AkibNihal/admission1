// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, World!");

Bulb bulb = new Bulb();

bulb.On += () => Console.WriteLine("event turn on");
bulb.Off += () => Console.WriteLine("event turn off");

bulb.TurnON();
bulb.TurnOff();
