using System;
using System.Collections.Generic;
using System.Text;

namespace ReUseDelegate
{
    public class Phone : IPhone
    {
        public void Hangup() 
        {
            Console.WriteLine("Call Hangup");
        }
        public void Release()
        {
            Console.WriteLine("Call Release");
        }
    }
}
