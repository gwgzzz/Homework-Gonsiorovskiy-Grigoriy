using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS_3_Exercise__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex x = new Complex(12, 13);
            

            Complex z = new Complex(4, -15);
            

            Complex s = x + z;
            Console.WriteLine($"({x}) + ({z}) = {s}");


            Complex c = x - z;
            Console.WriteLine($"({x}) - ({z}) = {c}");
        }
    }
}
