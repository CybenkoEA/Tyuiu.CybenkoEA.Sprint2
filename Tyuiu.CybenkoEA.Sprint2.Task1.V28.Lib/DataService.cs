using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.CybenkoEA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | ((c == d) & !(b > a)) ^ (c >= d);

            res[1] = (a > b) & ((c != d) | !(b <= a)) ^ (c < d);

            res[2] = (c == d) & ((a != b) | !(c <= d)) ^ (b > a);

            res[3] = (a > b) | ((c != d) & !(a < b)) ^ (c == d);

            res[4] = (b > a) & ((c == d) | !(a >= b)) ^ (d >= c);

            res[5] = (a == b) | ((c < d) & !(b > a)) ^ (c != d);

            return res;
        }
    }
}