using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskykhVA.Sprint2.Task2.V20.Lib;

namespace Tyuiu.KosovskykhVA.Sprint2.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task2                                                           *");
            Console.WriteLine("*Вариант #20                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет находится ли точка                 ");
            Console.WriteLine("* с координатами X,Y в заштрихованной области                             *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            bool res = service1.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }


            Console.ReadKey();
        }
    }
}
