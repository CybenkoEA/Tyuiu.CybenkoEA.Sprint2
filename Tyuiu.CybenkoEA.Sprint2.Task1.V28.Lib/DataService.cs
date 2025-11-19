using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.CybenkoEA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | ((c != d) & !(b <= a)) ^ (c > d); // true
            res[1] = (a > b) & (d >= c) & false; // false
            res[2] = (c == d) & (b > a); // true
            res[3] = (a == b) | false; // false
            res[4] = (b > a) | ((c == d) & !(a > b)) ^ (d != c); // true
            res[5] = (c < d) & (a >= b); // false
            return res;
        }


    }
}