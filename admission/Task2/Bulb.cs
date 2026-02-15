using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Bulb
    {
        public event Action<string> On;
        public event Action<string> Off;

        public void TurnON()
        {
            Console.WriteLine("Bulb On");
            On?.Invoke("bulb on string");
        }
        
        public void TurnOff()
        {
            Console.WriteLine("Bulb Off");
            Off?.Invoke("bulb off string"); 
        }
    }
}

