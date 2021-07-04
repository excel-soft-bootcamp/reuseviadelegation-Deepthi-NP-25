using System;

namespace ReUseDelegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Camera camera = new Camera();
            GPS gps = new GPS();
            Phone phone = new Phone();

            SmartPhone smartPhone = new SmartPhone();//Smartphone Should Delegate Calls to  Camera, Gps,Phone
            smartPhone.SetCamera(camera);
            smartPhone.SetGPS(gps);
            smartPhone.SetPhone(phone);

            Traveller traveller = new Traveller();
            traveller.Hike(smartPhone);
            traveller.Hike(gps);

            Person person = new Person();
            person.Communicate(smartPhone);
            person.Communicate(phone);
        }
    }
}

        
