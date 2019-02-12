using System;
using System.Collections.Generic;
using System.Text;
using ECS.Refactored.Random;

namespace ECS.Refactored.TempSensor
{
    public class FakeTempSensor : ITempSensor
    {
        private IRandom _gen;

        public FakeTempSensor(IRandom gen)
        {
            _gen = gen;
        }


        public int GetTemp()
        {
            return _gen.NextRandomNumber(-5, 45);
        }
    }
}
