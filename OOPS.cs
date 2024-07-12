using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    public interface IGrandParent
    {
        void Print();

    }
    abstract class AbsParent: IGrandParent
    {
        public void Print()
        {
            Console.WriteLine("Implementation of Print method of IGrandParent class\n");
        }

        public abstract void Print1();
    }

    class Child: AbsParent
    {
        public override void Print1()
        {
            Console.WriteLine("Print1 method is implemented or overrided");
        }
        public Child()
        {
            Console.WriteLine("Calling default constructor of Child class");
        }
        public void ChildPrint()
        {
            Console.WriteLine("Method of Child class -- Child Parent");
        }
        ~Child()
        {
            Console.WriteLine("Calling destructor of Child Class");
        }
    }
    internal class OOPS : Child
    {
        static int x;
        OOPS()
        {
            Console.WriteLine("Default constructor of OOPS");
        }
        OOPS(int val)
        {
            Console.WriteLine($"Overloading constructor of OOPS : val - {val}");
        }
        ~OOPS()
        {
            Console.WriteLine("Calling destructor of OOPS");
        }
        public override void Print1()
        {
            Console.WriteLine("Overriding method of Child Class -- Print1");
        }
        static OOPS()
        {
            x = 90;
            Console.WriteLine($"Calling static Constructor of OOPS class. x = {x}");
        }

        static void Main(String[] args)
        {
            OOPS oops1 = new OOPS();
            OOPS oops2 = new OOPS(10);
            Child c = new Child();
            oops1.Print();
            c.Print1();
            c.Print();
            c.ChildPrint();
            Console.WriteLine("Encapsulation is achieved");
        }

    }
}



Output:
Calling static Constructor of OOPS class. x = 90
Calling default constructor of Child class
Default constructor of OOPS
Calling default constructor of Child class
Overloading constructor of OOPS : val - 10
Calling default constructor of Child class
Implementation of Print method of IGrandParent class

Print1 method is implemented or overrided
Implementation of Print method of IGrandParent class

Method of Child class -- Child Parent
Encapsulation is achieved
Calling destructor of Child Class
Calling destructor of OOPS
Calling destructor of Child Class
Calling destructor of OOPS
Calling destructor of Child Class
