using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace исключения
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("КАЛЬКУЛЯТОР");
            Console.Write("введите a=");
           int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("коды операций");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умночение");
            Console.WriteLine("4 - частное");
            Console.Write("введите код операции: ");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    {
                        int s = a + b;
                        Console.WriteLine("сумма a и b = {0}", s);
                        break;
                    }
                case 2:
                    {
                        int d = a - b;
                        Console.WriteLine("разность a и b = {0}", d);
                        break;
                    }
                case 3:
                    {
                        int m = a * b;
                        Console.WriteLine("произведение a и b = {0}", m);
                        break;
                    }
                case 4:
                    {
                        int n = a / b;
                        Console.WriteLine("частное a и b = {0}", n);
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
