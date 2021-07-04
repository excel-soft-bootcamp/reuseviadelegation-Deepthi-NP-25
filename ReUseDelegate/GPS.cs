using System;
using System.Collections.Generic;
using System.Text;

namespace ReUseDelegate
{
    public class GPS : IGPS
    {
        public void Navigate()
        {
            Console.WriteLine("Navigate through GPS");
        }
    }
}
