using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calck
{
    class Program
    {

        static void Main(string[] args)
        {

            double a;
            double b;
            double res = 0;
            char oper;

            Console.Write("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.Write("\nВведите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                res = a + b;
            }

            else if (oper == '-')
            {
                res = a - b;
            }

            else if (oper == '*')
            {
                res = a * b;
            }

            else if (oper == '/')
            {
                if (b != 0)
                    res = a / b;
                else Console.WriteLine("На 0 делить нельзя!");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }

            Console.WriteLine("\nРезультат: {0}", res);
            Console.ReadLine();
        }
    }
}