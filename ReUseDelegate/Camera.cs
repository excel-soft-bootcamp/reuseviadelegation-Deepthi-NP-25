using System;
using System.Collections.Generic;
using System.Text;

namespace ReUseDelegate
{
    public class Camera : ICamera
    {
        public void TakePicture() 
        {
            Console.WriteLine("Picture taken by Camera");
        }

    }
}
