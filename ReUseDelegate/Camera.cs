using System;
using System.Collections.Generic;
using System.Text;

namespace ReUseDelegate
{
    public class Camera : ICamera
    {
        public void Click() 
        {
            Console.WriteLine("Click by Camera");
        }

    }
}
