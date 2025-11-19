using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.CybenkoEA.Sprint2.Task3.V16.Lib
{
    public class DataService : ISprint2Task3V16
    {
        public double Calculate(double x)
        {
            if (x > 1)
                return Math.Round(x + Math.Pow(((x + 1) / (x - 1)), 3), 3);
            else if (x == 0)
                return Math.Round((2 * x * x - Math.Cos(x) * Math.Cos(x) + 10) / (5 * x * x - Math.Sin(x) * Math.Sin(x) + 12), 3);
            else if (-20 < x & x < 2)
                return Math.Round(Math.Pow((1 + 1 / (x * x)), 7), 3);
            else
                return Math.Round((x + 10 * x - (1 / x)), 3);
        }
    }
}
