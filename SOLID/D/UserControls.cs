using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class UserControls : IUserControls
    {
        public UserControls()
        {
        }

        public bool Rmb { get; set; }
        public void OnRightMouseClick()
        {
            Rmb = true;
        }
    }
}
