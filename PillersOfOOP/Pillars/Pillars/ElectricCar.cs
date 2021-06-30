using System;
using System.Collections.Generic;
using System.Text;

namespace Pillars
{
    class ElectricCar : Car
    {
        public override string EngineStart(bool hasKey)
        {
            return "silence";
        }
    }
}
