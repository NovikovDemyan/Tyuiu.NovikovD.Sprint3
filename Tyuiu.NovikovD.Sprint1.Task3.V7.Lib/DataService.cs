using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NovikovD.Sprint1.Task3.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovD.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double verst)
        {
            const double VERST_TO_METERS = 1066.8;
            const double METERS_TO_KILOMETERS = 0.001;
            double result = verst * VERST_TO_METERS * METERS_TO_KILOMETERS;
            return Math.Round(result, 3);
        }
    }
}
