using System;
using System.Collections.Generic;
using System.Text;

namespace ReUseDelegate
{
    public class SmartPhone : ICamera, IGPS, IPhone
    {
        ICamera camera;
        IGPS gps;
        IPhone phone;

        public void SetCamera(ICamera camera)
        {
            this.camera = camera;
        }
        public void SetGPS(IGPS gps)
        {
            this.gps = gps;
        }
        public void SetPhone(IPhone phone)
        {
            this.phone = phone;
        }
        public void TakePicture()
        {
            this.camera.TakePicture();
        }
        public void Hangup()
        {
            this.phone.Hangup();
        }
        public void Release()
        {
            this.phone.Release();
        }
        public void Navigate()
        {
            this.gps.Navigate();
        }
    }
}
