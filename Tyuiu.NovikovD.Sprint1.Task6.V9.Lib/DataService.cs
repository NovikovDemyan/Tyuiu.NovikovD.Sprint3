using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovD.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int dayNumber)
        {
            if (dayNumber == 1) return "Понедельник";
            else if (dayNumber == 2) return "Вторник";
            else if (dayNumber == 3) return "Среда";
            else if (dayNumber == 4) return "Четверг";
            else if (dayNumber == 5) return "Пятница";
            else if (dayNumber == 6) return "Суббота";
            else if (dayNumber == 7) return "Воскресенье";
            else return "Ошибка: некорректный номер дня";
        }
    }
}
