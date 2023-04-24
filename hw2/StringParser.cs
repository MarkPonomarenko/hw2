using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class StringParser
    {
        public List<int> GetDigits(string input)
        {
            string numbersString = new string(input.Where(char.IsDigit).ToArray());
            List<int> numbers = new List<int>();
            for (int i = 0; i < numbersString.Length; i++)
            {
                numbers.Add(numbersString[i] - '0');
            }

            return numbers;
        }

        public List<int> GetNumbers(string input)
        {
            StringBuilder integerStr = new StringBuilder();
            StringBuilder stringBuilder = new StringBuilder();
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
            List<int> numbers = new List<int>();
            for (int i = 0; i < numbersStr.Length - 1; i++)
            {
                numbers.Add(int.Parse(numbersStr[i]));
            }
            return numbers;
        }

        public int GetSum(List<int> input)
        {
            return input.Sum();
        }

        public int GetMax(List<int> input)
        {
            return input.Count == 0 ? 0 : input.Max();
        }
    }
}
