using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.CybenkoEA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // 1. True: (a < b) = True
            res[0] = (a < b) | ((c == d) & !(a > b)) ^ (c >= d);

            // 2. False: (a > b) = False & ... 
            res[1] = (a > b) & ((c != d) | !(b > a)) ^ (c < d);

            // 3. True: (c == d) = True & (b > a) = True
            res[2] = (c == d) & ((b > a) | !(a == b)) ^ (d <= c);

            // 4. False: (a == b) = False | ... с отрицанием чтобы получить False
            res[3] = (a == b) | ((c < d) & !(d == c)) ^ (b >= a);

            // 5. True: (b > a) = True & (c == d) = True  
            res[4] = (b > a) & ((c == d) | !(a >= b)) ^ (d != c);

            // 6. False: (c < d) = False & ... 
            res[5] = (c < d) & ((a >= b) | !(b > a)) ^ (d == c);

            return res;
        }
    }
}