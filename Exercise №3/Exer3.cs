using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__3
{
    class Exer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчет введённых нечётных положительных чисел. Введите 0, чтобы прервать подсчёт");

            int sum = 0;
            int hold = 1;
            while (hold != 0)
            {
                Console.WriteLine("Введите число: ");
                int numZ3 = ReadNumInt();
                if (numZ3 > 0 && numZ3 % 2 != 0)
                { sum = sum + numZ3; }
                if (numZ3 == 0) { hold = 0; }
            }

            Console.WriteLine($"Результат равен: {sum}");
        }


        static int ReadNumInt()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
    }

}
