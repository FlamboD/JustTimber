using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{

    class HelloWorld
    {

        static void Main(string[] args)
        {
            int One;
            int Two;
            int Add;
            Console.WriteLine("Repeat:");
            /*Console.ReadLine();*/
            One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("+");
            Two = Convert.ToInt32(Console.ReadLine());
            Add = One + Two;
            Console.WriteLine((One)+" + "+(Two)+" = "+Add);
            Console.Equals(One, Two);
            {
                Console.WriteLine("Amazing!");
                Console.ReadLine();
            }
            Console.Clear();
            Console.ReadLine();
        }
    }
}