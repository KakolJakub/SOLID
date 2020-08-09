using System;
using SOLID.S;
using SOLID.O;
using SOLID.L;
//using SOLID.I;
//using SOLID.D;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Rectangle a = new Rectangle();
            
            a.SetHeight(6);
            a.SetLength(7);
            a.ShowSize();

            Console.ReadKey();
          
        }
    }
    
}
