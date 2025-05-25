using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovD.Sprint1.Task5.V4.Lib
{
    public class DataService
    {
        public int CalculateHours(int totalSeconds)
        {
            const int SECONDS_PER_HOUR = 3600;
            return totalSeconds / SECONDS_PER_HOUR;
        }
    }
}
