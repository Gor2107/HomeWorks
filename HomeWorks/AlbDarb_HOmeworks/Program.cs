using System;
using p = System.Console;


namespace MyNamespace
{
    class A
    {
        protected void fA() { p.WriteLine("FA"); }
    }
    class B : A
    {
        public void fB() { p.WriteLine("FB"); fA(); }

    }
    class C : B
    {
        public void fC() { p.WriteLine("FC"); }

    }
    class MyClass
    {
        public static void Main()
        {
            A obA = new A();
            B obB= new B();
            C obC = new C();
           
            obC = (C)obB;


        }

    }



}