using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__2
{
    class Exser2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int numZ2 = Math.Abs(ReadNumInt());
            int count = 0;


            do { count++; numZ2 /= 10; }
            while (numZ2 >= 1);

            Console.WriteLine($"Количество цифр в числе равно: {count}");
        }

        static int ReadNumInt()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
    }
}
