// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, World!");

Bulb bulb = new Bulb();

bulb.On += (stat) => Console.WriteLine("event turn on");
bulb.Off += (stat) => Console.WriteLine("event turn off");

bulb.TurnON();
bulb.TurnOff();

