using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovD.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int k)
        {
            switch (k)
            {
                case 6: return "Шестерка";
                case 7: return "Семерка";
                case 8: return "Восьмерка";
                case 9: return "Девятка";
                case 10: return "Десятка";
                case 11: return "Валет";
                case 12: return "Дама";
                case 13: return "Король";
                case 14: return "Туз";
                default: return "Некорректный номер карты";
            }
        }
    }
}
