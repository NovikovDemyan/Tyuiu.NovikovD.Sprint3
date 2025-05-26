using System;
using System.Collections.Generic;

namespace Tyuiu.NovikovD.Sprint3.Task6.V24.Lib
{
    public class DataService
    {
        public Dictionary<int, int> CountDivisorsInRange(int start, int end)
        {
            Dictionary<int, int> divisorsCount = new Dictionary<int, int>();

            for (int number = start; number <= end; number++)
            {
                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                divisorsCount[number] = count;
            }

            return divisorsCount;
        }
    }
}
