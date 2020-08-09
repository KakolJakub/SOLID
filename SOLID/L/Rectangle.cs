using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.L
{
    public class Rectangle
    {
        public int Length
        { get; private set; }

        public int Height
        { get; private set; }

        public void ShowSize()
        {
            Console.WriteLine("Długość: " + Length);
            Console.WriteLine("Wysokość: " + Height);
        }

        public void SetLength(int length)
        {
            Length = length;
        }
        public void SetHeight(int height)
        {
            Height = height;
        }
    }
}
