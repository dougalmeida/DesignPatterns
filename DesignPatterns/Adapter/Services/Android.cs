using DesignPatterns.Adapter.Interfaces;
using System;

namespace DesignPatterns.Adapter.Services
{
    public class Android : IMicroUsbPhone
    {
        private bool connector;

        public void UseMicroUsbPhone()
        {
            connector = true;
            Console.WriteLine("MicroUsb connected ...");
        }

        public void Recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharge started ...");
                Console.WriteLine("Recharge finished ...");
            }
            else
            {
                Console.WriteLine("Connect MicroUsb first ...");
            }
        }
    }
}