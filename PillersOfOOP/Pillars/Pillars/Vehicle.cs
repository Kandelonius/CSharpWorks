using System;

namespace Pillars
{
    class Vehicle // Inheritance - top parent
    {
        // Polymorphism - if the car is a manual the starting procedure changes
        // this is an example of method overloading so it is compile time polymorphism
        // overloading occurs when a method is called with the same name but different paramiters
        public string EngineStart(Boolean hasKey)
        {
            return "Vroom";
        }
        public string EngineStart(Boolean hasKey, Boolean isManual)
        {
            return "Hold down the clutch to start";
        }
    }
}
