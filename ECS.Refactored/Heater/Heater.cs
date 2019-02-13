﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Heater
{
    public class Heater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
        }

    }
}
