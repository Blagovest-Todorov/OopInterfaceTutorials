using System;

namespace _28.OopInterfaceTuition
{
    interface MyInterface //defining the Interface !!! IOnterface is mush like an empty class, it contains only declared method !
    {
        void myMethod(); // there is no methods Mody defined !!! Empty Body !!
    }

    class MyClass : MyInterface  //Defining the class that inherits the interface !  //Child class ! 
    {
        public void myMethod() //here we implement the Methods body, we define it fully, so we can use it later !
        {
            Console.WriteLine("Welcome to MCN IT Solution");
            Console.ReadLine();
        }

        public static void Main() 
        {
            MyClass cls = new MyClass();
            cls.myMethod();
        }



    }
}
