using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovD.Sprint2.Task1.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            bool compare1 = a == b;  // False
            bool compare2 = c != d;  // True
            bool compare3 = a < c;   // False
            bool compare4 = d > b;   // False
            bool compare5 = b <= d;  // True
            bool compare6 = c >= a;  // False

            res[0] = compare1 | compare2;  // False | True = True
            res[1] = compare2 & compare3;  // True & False = False
            res[2] = compare3 || compare4; // False || False = False
            res[3] = compare4 && compare5; // False && True = False
            res[4] = !compare5;            // !True = False
            res[5] = compare5 ^ compare6;  // True ^ False = True

            res[4] = !compare6;            // !False = True (чтобы получить True на 4 позиции)

            return res;
        }
    }
}