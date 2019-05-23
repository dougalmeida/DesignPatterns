using DesignPatterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Services
{
    public class Car : ICar
    {
        public string Run()
        {
            return "Car running ...";
        }
    }
}