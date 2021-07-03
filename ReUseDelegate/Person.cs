using System;
using System.Collections.Generic;
using System.Text;

namespace ReUseDelegate
{
    public class Person
    {
        public void Communicate(IPhone phone)
        {
            
            phone.Hangup();
            phone.Release();
        }
    }
}
