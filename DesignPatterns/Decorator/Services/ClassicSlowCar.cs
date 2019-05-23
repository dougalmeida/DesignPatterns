using DesignPatterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Services
{
    public class ClassicSlowCar : ICar
    {
        ICar _car;
        public ClassicSlowCar(ICar pCar)
        {
            _car = pCar;
        }
        public string Run()
        {
            return $"{_car.Run()} Slowly!";
        }
    }
}
