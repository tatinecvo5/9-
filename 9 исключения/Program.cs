using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_исключения
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
                Console.WriteLine("КАЛЬКУЛЯТОР");
            Console.Write("введите a=");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода a. " + ex.Message);
                Console.ReadKey();
                return;
            }
                Console.Write("введите b=");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода b. " + ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("коды операций");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умночение");
            Console.WriteLine("4 - частное");
            Console.Write("введите код операции: ");
            c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    {
                        double s = a + b;
                        Console.WriteLine("сумма a и b = {0}", s);
                        break;
                    }
                case 2:
                    {
                        double d = a - b;
                        Console.WriteLine("разность a и b = {0}", d);
                        break;
                    }
                case 3:
                    {
                        double m = a * b;
                        Console.WriteLine("произведение a и b = {0}", m);
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            double n = a / b;
                            Console.WriteLine("частное a и b = {0:f2}", n);
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка - деление на 0!");
                        }
                                                break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка ввода кода операции!");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
