using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovD.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            return string.Join(" ", text.Split(' ')
                .Select(word => word.Length > 0
                    ? word[word.Length - 1] + word.Substring(0, word.Length - 1)
                    : word));
        }
    }
}
