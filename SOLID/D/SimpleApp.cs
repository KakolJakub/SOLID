using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class SimpleApp
    { 

        public void Work()
        {
            IUserControls uc = new UserControls();
            IUserInterface ui = new UserInterface();

            ui.DisplayMenu(uc);
        }
       
    }
}
