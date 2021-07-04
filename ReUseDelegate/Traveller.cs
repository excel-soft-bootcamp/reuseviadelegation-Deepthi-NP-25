using System;
using System.Collections.Generic;
using System.Text;

namespace ReUseDelegate
{
    public class Traveller
    {
        public void Hike(IGPS gps)
        {
            gps.Navigate();
        }
    }
}
