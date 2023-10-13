using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskykhVA.Sprint2.Task1.V9.Lib;

namespace Tyuiu.KosovskykhVA.Sprint2.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task1                                                           *");
            Console.WriteLine("*Вариант #9                                                               *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, из операция сравнений ==, !=, <, >, <=, >=           ");
            Console.WriteLine("* и логических операций |, &, ||, &&, !, ^                                *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            bool[] res = service1.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();
        }
    }
}
