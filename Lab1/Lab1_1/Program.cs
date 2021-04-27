using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double variabl_a;
            double variabl_b;
            double total = 0;
            char oper;
            Console.WriteLine("Введите первое число");
            variabl_a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оператор");
            oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            variabl_b = Convert.ToDouble(Console.ReadLine());
            switch (oper)
            {
                case '+':
                    total = variabl_a + variabl_b;
                    break;

                case '-':
                    total = variabl_a - variabl_b;
                    break;
                case '*':
                    total = variabl_a * variabl_b;
                    break;
                case '/':

                    total = variabl_a / variabl_b;
                    break;
            }
            Console.WriteLine("Результат = " + total);
            Console.ReadLine();
        }
    }
}
