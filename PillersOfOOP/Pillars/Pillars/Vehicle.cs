using System;

namespace Pillars
{
    class Vehicle // Inheritance - top parent
    {
        // Polymorphism - if the car is a manual the starting procedure changes
        // this is an example of method overloading so it is compile time polymorphism
        // overloading occurs when a method is called with the same name but different paramiters

        // this field is accessible in inherited classes due to inheritence, but must be accessed using
        // the Wheels property
        protected static int wheels; 

        // default implementation that claims a vehicle must have at least 1 wheel
        public virtual int Wheels
        {
            get { return wheels; }
            set
            {
                if (value > 0)
                {
                    wheels = value;
                }
            }
        }

        public virtual string EngineStart(Boolean hasKey)
        {
            return "Vroom";
        }
        public string EngineStart(Boolean hasKey, Boolean isManual)
        {
            return "Hold down the clutch to start";
        }
    }
}
