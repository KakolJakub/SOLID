using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class UserInterface : IUserInterface
    {
        public void DisplayMenu(IUserControls a)
        {
            IUserControls controls = a;

            if (controls.Rmb == true)
            {
                //Display menu
                Console.WriteLine("Wyświetlono menu.");
            }
        }
    }
}
