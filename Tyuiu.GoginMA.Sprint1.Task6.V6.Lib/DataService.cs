using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoginMA.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] words = value.Split(' ');
            string Text = "";

            foreach (string word in words)
            {
                if (word.Length > 1)
                {
                    string x = word.Substring(1);

                    Text += x + " ";
                }
            }
            return Text.Trim();
        }
    }
}
