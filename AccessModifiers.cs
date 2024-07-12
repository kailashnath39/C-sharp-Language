using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    
    public class AccessModifiers
    {
        private int a = 10;
        public int b = 20;
        protected int c = 30;
        protected private int d = 40;
        internal int e = 50; // or int e;
        static void Main(string[] args)
        {
            AccessModifiers am = new AccessModifiers();
            Console.WriteLine($"in static method of Access modifiers b = {am.b} c = {am.c} d = {am.d} e = {am.e}");
            am.func();
            xyz.AM2 am2 = new xyz.AM2();
            am2.Print();
        }
        void func()
        {
            Console.WriteLine($"in static method of Access modifiers a = {a} b = {b} c = {c} d = {d} e = {e}");
        }
    }
    class ChildAccessModifiers: AccessModifiers
    {

        void func1()
        {
            Console.WriteLine($"in child method of Access Modifiers b = {b} c = {c} d = {d} e = {e}");
        }
    }
}

namespace xyz
{
    // you can not access a protected and protected private variable by forming object of class of anpther name space
    // instead inherit and directly access the variables
    public class AM2: PracticeCsharp.AccessModifiers
    {
        public void Print()
        {
            Console.WriteLine($"In another name space b = {b} c = {c} d = {d}");
        }
    }
}


Output:
in static method of Access modifiers b = 20 c = 30 d = 40 e = 50
in static method of Access modifiers a = 10 b = 20 c = 30 d = 40 e = 50
In another name space b = 20 c = 30 d = 40

