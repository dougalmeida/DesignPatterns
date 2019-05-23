using DesignPatterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.Services
{
    public static class AdapterService
    {
        public static void RechargeMicroUsbPhone(IMicroUsbPhone phone)
        {
            phone.UseMicroUsbPhone();
            phone.Recharge();
        }

        public static void RechargeLightningPhone(ILightningPhone phone)
        {
            phone.UseLightning();
            phone.Recharge();
        }
    }
}