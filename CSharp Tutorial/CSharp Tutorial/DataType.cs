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

            /*
             * Var Keyword
             * 
             * 1. Whenever you declare var you must assign a value to it
             * 2. Var cannot be assigned a Null value
             * 3. When var is assigned a value it will be stored as a data type
             * 4. When it is assigned as a data type it will behave as an original data type
             * 5. You can use var as a local variable
             * 6. Can't declare var as a class level variable or parameterized variable
             * 7. Can't use var as a return type
             */

            MyClass obj = new MyClass();

            var o = 100;
            o = 150;
            o = (int)(double)15.5;

            Console.WriteLine(0);
            Console.WriteLine(obj.number);//0
            Console.WriteLine("-----------------------");
            Console.WriteLine(obj.name);//null
            Console.WriteLine("-----------------------");
            Console.ReadKey();
        }

    }
}
