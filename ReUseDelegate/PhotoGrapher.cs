using System;
using System.Collections.Generic;
using System.Text;

namespace ReUseDelegate
{
    public class PhotoGrapher
    {
        public void Capture(ICamera camera)
        {
            
            camera.Click();
        }
    }
}
