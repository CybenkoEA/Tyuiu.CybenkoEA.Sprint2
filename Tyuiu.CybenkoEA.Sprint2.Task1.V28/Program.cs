using Tyuiu.CybenkoEA.Sprint2.Task1.V28.Lib;
namespace Tyuiu.CybenkoEA.Sprint2.Task1.V28
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Цыбенко Евгений Андреевич | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Операции сравнения                                                      *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Цыбенко Евгений Андреевич | ИИПБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один");
            Console.WriteLine("*раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также*");
            Console.WriteLine("*арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, False, True, False), при a =*");
            Console.WriteLine("*247, b = 654, c = 671, d = 671                               *");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine($"D = {d}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Результат:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {res[i]}");
            }

            Console.ReadKey();
        }
    }



}