using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovD.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            // Последовательность операций сравнения
            results[0] = x == y + 7830;  // True (8105 == 275 + 7830)
            results[1] = x != y + 7830;   // False
            results[2] = x > y;           // True
            results[3] = x < y;           // False
            results[4] = x >= y * 29;     // True (8105 >= 7975)
            results[5] = x <= y / 2;      // False

            return results;
        }
    }
}