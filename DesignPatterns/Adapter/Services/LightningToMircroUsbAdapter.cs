using DesignPatterns.Adapter.Interfaces;
using System;

namespace DesignPatterns.Adapter.Services
{
    public class LightningToMircroUsbAdapter : IMicroUsbPhone
    {
        private ILightningPhone _lightningPhone;

        public LightningToMircroUsbAdapter(ILightningPhone pLightningPhone)
        {
            _lightningPhone = pLightningPhone;
        }
        
        public void UseMicroUsbPhone()
        {
            Console.WriteLine("MicroUsb connected ...");

            _lightningPhone.UseLightning();
        }

        public void Recharge()
        {
            _lightningPhone.Recharge();
        }
    }
}