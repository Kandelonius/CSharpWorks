using System;

namespace DataType
{
    class MyClass
    {
        int number;

        string name;

        //Field Example
        int nonStaticField;
        static int staticField;

        //Property Example
        public int NonStaticProperty { get; set; }
        public static int StaticProperty { get; set; }

        //Method Example

        void NonStaticMethod()
        {

        }

        public static void StaticMethod()
        {

        }

        public static void Lecture()
        {
            sbyte a = 120;
            short b = a; // sbyte can be implicitly converted into short
            sbyte c = 27;

            MyClass obj = new MyClass();

            var o = 100;
            o = 150;
            o = (int)(double)15.5;// this would be bad practice
            o = (int)(Char)'A';// this would be very bad practice

            int j = 100;
            object k = j; // boxing
            int l = (int)k; // unboxing

            Console.WriteLine(0);
            Console.WriteLine(obj.number);//0
            Console.WriteLine("-----------------------");
            Console.WriteLine(obj.name);//null
            Console.WriteLine("-----------------------");
            Console.ReadKey();
        }
    }
}
