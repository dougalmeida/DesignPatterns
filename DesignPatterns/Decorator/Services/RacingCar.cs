using DesignPatterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Services
{
    public class RacingCar : ICar
    {
        ICar _car;

        public RacingCar(ICar pCar)
        {
            _car = pCar;
        }
        public string Run()
        {
            return $"{_car.Run()} Fastly!";
        }

        public string RunFast()
        {
            return "Car racing fast ...";
        }
    }
}
