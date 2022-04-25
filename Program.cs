using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    // Default Constructor
    // Implicitly Called (Constructor)
    /*internal class Program
    {
        int i; bool b;
        static void Main(string[] args)
        {
            Program p=new Constructor.Program();

            Console.WriteLine(p.i);
            Console.WriteLine(p.b);

            Console.ReadLine();
        }
    }*/


    // Explicitly Called (Constructor)
    /*class Test
    {
        int i; string s; bool b;

        public Test()
        {
            i = 10;
            s = "Alok";
            b = true;
        }

        static void Main()
        {
            Test t = new Constructor.Test();

            Console.WriteLine(t.i);
            Console.WriteLine(t.s);
            Console.WriteLine(t.b);

            Console.ReadLine();
        }
    }*/

    // Parameterized Constructor
    // Explicitly Called (Constructor)

    /*class PCTOR
    {
        public PCTOR(int i)
        {
            Console.WriteLine("Parameterized Constructor is called: " + i);
        }

        static void Main()
        {
            PCTOR pc = new PCTOR(10);

            Console.ReadLine();
        }
    }*/

    //Copy Constructor
    /*class CCTOR
    {
        int p;
        public CCTOR(int i)
        {
            p = i;
        }

        public CCTOR(CCTOR obj)
        {
            p = obj.p;
        }
        public void Display()
        {
            Console.WriteLine("Value of x is : " + p);
        }

        static void Main()
        {
            CCTOR cc = new CCTOR(100);
            cc.Display();
            CCTOR cc2 = new CCTOR(cc);
            cc2.Display();
            Console.ReadLine();
        }
    }*/

    // Static Constructor(Parameter Less)
    class SCTOR
    {
        static SCTOR()
        {
            Console.WriteLine("static constructor is called: ");
        }

        static void Main()
        {
            Console.ReadLine(); 
        }
    }
}
