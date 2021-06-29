using System;

namespace Pillars
{
    class PillarsMain //
    {
        static void Main(string[] args)
        {
            Car newcar = new Car();
            ElectricCar volt = new ElectricCar();

            newcar.Wheels = 4;

            Console.WriteLine($"this car has {newcar.Wheels} wheels");
            Console.WriteLine($"Electric car says {volt.EngineStart(true)}");



            Console.Read();
        }
    }
}
