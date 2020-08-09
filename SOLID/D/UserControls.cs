using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class UserControls
    {
        public bool Rmb { get; private set; }
        public void OnRightMouseClick()
        {
            Rmb = true;
        }
    }
}
