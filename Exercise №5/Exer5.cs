using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__5
{
    class Exer5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчёта Индекса Массы Тела. Введите свой рост в сантиметрах: ");
            double height = ReadNumDouble() / 100;
            Console.WriteLine("Введите свой вес в килограммах: ");
            double mass = ReadNumDouble();
            double IndMass = mass / (height * height);
            double IndMassmax = 24.99;
            double IndMassmin = 18.5;
            int IMT = 0;
            double masopt = 0;
            if (IndMass > IndMassmax) { IMT = 1; }

            else if (IndMass < IndMassmin) { IMT = 2; }

            double IMTresult;
            switch (IMT)
            {
                case 1:
                    masopt = IndMassmax * (height * height);
                    IMTresult = Math.Abs(mass - masopt);
                    Console.WriteLine($"Ваш индекс массы тела равен {IndMass}, многовато.");
                    Console.WriteLine($"Вам стоит похудеть на {IMTresult} килограмм");
                    break;

                case 2:
                    masopt = IndMassmin * (height * height);
                    IMTresult = Math.Abs(mass - masopt);
                    Console.WriteLine($"Ваш индекс массы тела равен {IndMass}, маловато.");
                    Console.WriteLine($"Вам стоит набрать ещё {IMTresult} килограмм");
                    break;

                default:
                    Console.Write($"Ваш индекс массы тела равен {IndMass}, в пределах нормы.");
                    break;
            }
     
        }

        static double ReadNumDouble()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            return a;
        }
    }
}
