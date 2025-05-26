namespace Tyuiu.NovikovD.Sprint2.SprintReview.V3.Lib
{
    public class DataService
    {
        public bool IsPointInShadedArea(double x, double y)
        {
            return (x * x + (y - 1) * (y - 1) <= 1) && (y >= 1 - x * x);
        }
    }
}
