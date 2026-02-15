using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Bulb
    {
        public event Action On;
        public event Action Off;

        public void TurnON()
        {
            Console.WriteLine("Bulb On");
            On?.Invoke();
        }

        public void TurnOff()
        {
            Console.WriteLine("Bulb Off");
            Off?.Invoke(); 
        }
    }
}
