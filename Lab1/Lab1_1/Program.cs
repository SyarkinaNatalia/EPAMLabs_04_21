using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char oper;
            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оператор");
            oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Сумма чисел равна " + total);
            }
            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность чисел равна " + total);

            }
            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Произведение чисел равно " + total);

            }
            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("Частное чисел равно " + total);

            }
        }
    }
}
