using System;

namespace Pillars
{
    class Car : Vehicle // Inheritence - child of vehicle, example of hierarchical inheritance
    {

        // this is the car implementation of this property which indicates that a car must have a least 4 wheels
        public override int Wheels
        {
            get { return wheels; }
            set
            {
                if (value > 3)
                {
                    wheels = value;
                }
            }
        }

        public string transmission 
        { get; set; }

        public Car()
        {
        }

        public override string EngineStart(bool hasKey)
        {
            return "vroom vroom";
        }
    }
}
