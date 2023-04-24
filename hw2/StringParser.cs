using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class StringParser
    {
        public string GetTrimmedString(string input)
        {
            return input.TrimStart();
        }

        public int GetMaxDigitIndex(string input)
        {
            var digits = input.Where(char.IsDigit).Select(x => x - '0');
            return !digits.Any() ? -1 : input.IndexOf((char)(digits.Max() + 48));
        }

        public int GetMaxNumberIndex(string input)
        {
            StringBuilder integerStr = new StringBuilder();
            StringBuilder stringBuilder = new StringBuilder();
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    integerStr.Append(c);
                }
                else if (integerStr.Length > 0)
                {
                    stringBuilder.Append(integerStr);
                    stringBuilder.Append('.');
                    integerStr.Clear();
                }
            }
            if (integerStr.Length > 0)
            {
                stringBuilder.Append(integerStr);
                stringBuilder.Append('.');
            }
            string[] numbersStr = stringBuilder.ToString().Split(".");
            int[] numbers = new int[numbersStr.Length - 1];
            for (int i = 0; i < numbersStr.Length - 1; i++)
            {
                numbers[i] = int.Parse(numbersStr[i]);
            }
            return !numbers.Any() ? -1 : input.IndexOf(numbers.Max().ToString());
        }
    }
}
