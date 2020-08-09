using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public interface IUserControls
    {
        bool Rmb { get; set; }

        public void OnRightMouseClick();

    }
}
