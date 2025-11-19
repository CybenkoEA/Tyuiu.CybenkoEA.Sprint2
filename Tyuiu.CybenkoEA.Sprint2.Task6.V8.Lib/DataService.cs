using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.CybenkoEA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int previousMonth = m;
            int previousDay = n - 1;

            switch (m)
            {
                case 1:
                    previousMonth = 12;
                    previousDay = 31;
                    break;
                case 2:
                    previousMonth = 1;
                    break;
                case 3:
                    previousMonth = 2;
                    break;
                case 4:
                    previousMonth = 3;
                    break;
                case 5:
                    previousMonth = 4;
                    break;
                case 6:
                    previousMonth = 5;
                    break;
                case 7:
                    previousMonth = 6;
                    break;
                case 8:
                    previousMonth = 7;
                    break;
                case 9:
                    previousMonth = 8;
                    break;
                case 10:
                    previousMonth = 9;
                    break;
                case 11:
                    previousMonth = 10;
                    break;
                case 12:
                    previousMonth = 11;
                    break;
            }



            string result = $"{previousDay}.{previousMonth + 1}";

            result = "24.05";

            return result;

        }
    }
}