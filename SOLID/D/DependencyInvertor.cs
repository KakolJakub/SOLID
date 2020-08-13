using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public static class DependencyInvertor
    {
        public static IUserControls CreateUserControls()
        {
            return new UserControls();
        }

        public static IUserInterface CreateUserInterface()
        {
            return new UserInterface(CreateUserControls());
        }
    }
}
