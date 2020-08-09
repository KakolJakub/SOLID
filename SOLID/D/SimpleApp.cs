using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class SimpleApp
    { 

        public void Work()
        {
            UserInterface ui = new UserInterface();
            ui.DisplayMenu();
        }
       
    }
}
