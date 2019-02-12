using System;
using System.Collections.Generic;
using System.Text;
using ECS.Refactored.Logger;

namespace ECS.Refactored.Heater
{
    public class FakeHeater : IHeater
    {
        private readonly ILogger _logger;

        public FakeHeater(ILogger logger)
        {
            _logger = logger;
        }

        public void TurnOn()
        {
            /*TODO:Hvad er planen her?*/
        }

        public void TurnOff()
        {
            /*TODO:Hvad er planen her?*/
        }
    }
}
