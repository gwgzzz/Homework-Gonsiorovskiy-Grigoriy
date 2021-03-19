using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS_3_Exercise__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчета нечетных положительных чисел");
            Console.WriteLine("Введите число, для завершения введите 0: ");

            int AmOfNumber = 0;
            while (true)
            {
                int number = CheckInput();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    AmOfNumber++;
                }
            }

            Console.WriteLine($"{Environment.NewLine}Количество чисел: {AmOfNumber}");

            Console.ReadKey();
        }

        static int CheckInput()
        {
            int result = 0;
            bool exceptionCatched;
            do
            {
                exceptionCatched = false;
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    exceptionCatched = true;
                    string mess = ex.Message;
                    Console.WriteLine($"Возникла ошибка:{mess} ");
                    Console.Write("Пожалуйста, повторите ввод: ");
                }

            } while (exceptionCatched);
            return result;
        }

        static int getint()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                {
                    Console.Write("Неверный ввод требуется числовое значение. Пожалуйста, повторите ввод: ");
                }
                else return x;
        }

       

    }
}
