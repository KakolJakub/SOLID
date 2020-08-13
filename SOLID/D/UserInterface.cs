using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class UserInterface : IUserInterface
    {
        IUserControls controls;

        public UserInterface(IUserControls addedControls)
        {
            controls = addedControls;
        }

        public void DisplayMenu()
        {
            if (controls.Rmb == true)
            {
                //Display menu
                Console.WriteLine("Wyświetlono menu.");
            }
        }
    }
}
