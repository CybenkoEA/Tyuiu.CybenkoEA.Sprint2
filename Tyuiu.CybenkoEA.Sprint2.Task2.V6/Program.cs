using Tyuiu.CybenkoEA.Sprint2.Task2.V6.Lib;
namespace Tyuiu.CybenkoEA.Sprint2.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил: Цыбенко Е.А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи.                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил:  Цыбенко Е.А | ИИПБ-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("*                                                                         *");
            while (true)
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Введите x:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите y:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            }
        }
    }
}