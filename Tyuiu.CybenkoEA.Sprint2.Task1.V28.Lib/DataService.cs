using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.CybenkoEA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // Выражение 1: True
            // (a < b) = True, остальное не важно с OR
            res[0] = (a < b) | ((c != d) & !(b <= a)) ^ (c > d);

            // Выражение 2: False  
            // (a > b) = False в AND гарантирует False
            res[1] = (a > b) & ((c == d) | !(a < b)) ^ (d >= c);

            // Выражение 3: True
            // (c == d) = True в AND с другими True
            res[2] = (c == d) & ((b > a) | !(a == b)) ^ (d <= c);

            // Выражение 4: False
            // (a == b) = False в OR с другими False
            res[3] = (a == b) | ((c < d) & !(d == c)) ^ (b >= a);

            // Выражение 5: True
            // Комбинация True условий
            res[4] = (b > a) | ((c == d) & !(a > b)) ^ (d != c);

            // Выражение 6: False
            // Противоречивые условия
            res[5] = (c < d) & ((a >= b) | !(b > a)) ^ (d == c);

            return res;
        }
    }
}