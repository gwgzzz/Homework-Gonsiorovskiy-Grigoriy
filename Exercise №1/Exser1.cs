using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciese__2
{
    class Exser1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = ReadNumInt();
            Console.WriteLine("Введите второе число: ");
            int num2 = ReadNumInt();
            Console.WriteLine("Введите третье число: ");
            int num3 = ReadNumInt();

            int min = min33(num1, num2, num3);

            Console.WriteLine($"Меньшим из трёх введённых чисел является: {min} ");
            Console.ReadKey();


        }



        static int min33(int num1, int num2, int num3)
        {
            int min;
            if (num1 < num3 && num1 < num2) { min = num1; }
            else if (num2 < num3) { min = num2; }
            else { min = num3; }

            return min;
        }


        static int ReadNumInt()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
    }
}
