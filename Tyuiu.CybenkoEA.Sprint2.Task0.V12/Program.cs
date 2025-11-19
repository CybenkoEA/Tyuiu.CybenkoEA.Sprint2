using Tyuiu.CybenkoEA.Sprint2.Task0.V12.Lib;
namespace Tyuiu.CybenkoEA.Sprint2.Task0.V12
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Цыбенко Евгений Андреевич | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Операции сравнения                                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Цыбенко Евгений Андреевич | ИИПБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
            Console.WriteLine("*ательность операций не должна нарушаться) и арифметических выражений, кот*");
            Console.WriteLine("*торая вернет логическую последовательность(массив): (True, False, True, F*");
            Console.WriteLine("*False, True, False), при x = 1095, y = 475                               *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetCompareOperations(1095, 475);
            var s = "";
            foreach (var res in result)
            {
                s += " " + res.ToString();
            }
            Console.WriteLine(s.Substring(1));
            Console.ReadKey();
        }
    }



}