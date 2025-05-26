using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovD.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        static HashSet<(int x, int y)> shadedCells = new HashSet<(int x, int y)>
        {
        (3,3), (3,4), (3,5), (3,6), (3,7), (3,8), (3,9),
        (2,10), (3,10), (4,10), (5,10),
        (6,9), (6,8),
        (7,7),
        (8,6), (8,7), (8,8), (8,9), (8,10), (8,11), (8,12),
        (9,5), (9,6), (9,7), (9,8), (9,9), (9,10), (9,11), (9,12), (9,13),
        (10,4), (10,5), (10,6), (10,7), (10,8), (10,9), (10,10), (10,11), (10,12),
        (11,3), (11,4), (11,5), (11,6), (11,7), (11,8),
        (12,5), (12,6), (12,7)
        };

        public bool CheckDotInShadedArea(int x, int y)
        {
            return shadedCells.Contains((x, y));
        }
    }
}
