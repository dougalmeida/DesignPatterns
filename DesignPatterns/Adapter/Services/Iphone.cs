using DesignPatterns.Adapter.Interfaces;
using System;

namespace DesignPatterns.Adapter.Services
{
    public class Iphone : ILightningPhone
    {
        private bool connector;

        public void UseLightning()
        {
            connector = true;
            Console.WriteLine("Using Lightning ...");
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
                Console.WriteLine("Connect Lightning first ...");
            }
        }
    }
}