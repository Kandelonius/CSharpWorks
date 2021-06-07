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



        static void Main()
        {
            //Pre-Define OR Buit-In Data Types in C#    
            //int,double,char,bool,string,object etc.            

            //User - Defined Data Type in C#
            //class,object,array,delegate,interface,struct,enum,etc.


            //Value Type
            //int,double,char,bool,struct,enum etc.
            //It has default value 0.
            //Value type will be stored on Stack memory.
            //No GC required.


            //Reference Type
            //string,object,class,object,array,delegate,interface, etc.
            //It has default value null.
            //Referece type value will be stored on heap but reference will be stored stack.
            //GC is required to do the memory mamangement.



            //Console.WriteLine(i);
            //Console.WriteLine(name);

            //Class vs Object

            //India(Class)                         USA(Class)
            //Shri Narendra Modi(object)           Biden(object)

            //Class Members(field,Property,Method(non-static(object))(Static(class)))

            //How to create the instance of class
            //ClassName objectName=new ClassName();

            MyClass obj = new MyClass();



            Console.WriteLine(obj.number);//0
            Console.WriteLine("-----------------------");
            Console.WriteLine(obj.name);//null
            Console.WriteLine("-----------------------");
            Console.ReadKey();
        }

    }
}
