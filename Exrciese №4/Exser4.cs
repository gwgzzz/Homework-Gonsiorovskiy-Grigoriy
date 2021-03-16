using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrciese__4
{
    class Exser4
    {
        static void Main(string[] args)
        {
            string Logitrue = "root";
            string Pastrue = "GeekBrains";
            int attempts = 0;
            bool pass_control = false;

            do
            {
                Console.WriteLine("Введите логин: ");
                string Login = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string Pass = Console.ReadLine();

                attempts++;
                if (Login == Logitrue && Pass == Pastrue)

                { pass_control = true; break; }
                else

                if (attempts < 3)

                { Console.WriteLine("Неверно, попробуйте ещё раз."); }
            }
            while (attempts < 3);

            if (pass_control) { Console.WriteLine("Доступ разрешён."); }

            else { Console.WriteLine("Доступ запрещён."); }
        }
    }
}
