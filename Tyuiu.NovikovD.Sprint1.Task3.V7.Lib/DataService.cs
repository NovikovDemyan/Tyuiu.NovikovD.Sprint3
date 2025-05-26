namespace Tyuiu.NovikovD.Sprint3.Task3.V7.Lib
{
    public class DataService
    {
        public string ReplaceGWith4(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (c == 'g')
                    result += '4';
                else
                    result += c;
            }
            return result;
        }
    }
}
