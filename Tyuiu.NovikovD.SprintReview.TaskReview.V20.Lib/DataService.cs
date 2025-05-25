using System;

namespace Tyuiu.NovikovD.SprintReview.TaskReview.V20.Lib
{
    public class DataService
    {
        public double CalculateReviewFormula(double x, double y)
        {
            double term1 = 2 + Math.Pow(Math.Cos(x + y), 2);
            double term2 = 1 + Math.Abs(x - (3 * x / (1 + Math.Pow(x, 2))));
            double result = term1 / term2 + x * y;
            return Math.Round(result, 3);
        }
    }
}