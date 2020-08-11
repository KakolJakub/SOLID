using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class SimpleApp
    { 

        public void Work()
        {
            UserControls uc = new UserControls();
            UserInterface ui = new UserInterface();

            ui.DisplayMenu(uc);
        }
       
    }
}
