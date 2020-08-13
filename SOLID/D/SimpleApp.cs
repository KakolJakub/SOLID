using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class SimpleApp
    { 

        public void Work()
        {
            IUserInterface ui = DependencyInvertor.CreateUserInterface();

            ui.DisplayMenu();
        }
       
    }
}
