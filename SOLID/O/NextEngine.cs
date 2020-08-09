using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    class NextEngine : Engine
    {
        public void Refresh()
        {
            Console.WriteLine("Obniżono temperaturę w silniku.");
        }
    }
}
