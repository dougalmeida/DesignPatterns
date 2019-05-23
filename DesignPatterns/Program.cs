using DesignPatterns.Adapter.Services;
using DesignPatterns.Decorator.Services;
using System;

namespace DesignPatterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            PerformAdapterPattern();

            PerformDecoratorPattern();

            Console.ReadKey();
        }

        private static void PerformDecoratorPattern()
        {
            Car car = new Car();

            Console.WriteLine("Using a car ...");
            Console.WriteLine(car.Run());

            RacingCar racingCar = new RacingCar(car);

            Console.WriteLine("Using a racing car ...");
            Console.WriteLine(racingCar.Run());
            Console.WriteLine(racingCar.RunFast());

            
            ClassicSlowCar classicSlowCar = new ClassicSlowCar(car);

            Console.WriteLine("Using classic slow car ...");
            Console.WriteLine(classicSlowCar.Run());

            Console.ReadKey();
        }

        private static void PerformAdapterPattern()
        {
            Android android = new Android();

            Iphone iPhone = new Iphone();            

            AdapterService.RechargeMicroUsbPhone(android);
            Console.WriteLine("Recharging android with MicroUsb ...");

            AdapterService.RechargeLightningPhone(iPhone);
            Console.WriteLine("Recharging iPhone with Lightning ...");

            LightningToMircroUsbAdapter lightingPhoneAdaptee = new LightningToMircroUsbAdapter(iPhone);

            AdapterService.RechargeMicroUsbPhone(lightingPhoneAdaptee);
            Console.WriteLine("Recharging iPhone with MicroUsb");

            Console.ReadKey();
        }
    }    
}