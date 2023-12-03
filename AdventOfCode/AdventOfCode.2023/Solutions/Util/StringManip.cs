using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions.Util
{
    public class StringManip
    {
        public static List<NumberAndPosition<int>> GetIntegersFromString(string s)
        {
            List<NumberAndPosition<int>> numsResult = new List<NumberAndPosition<int>>();

            for (int i = 0; i < s.Length; i++)
            {
                NumberAndPosition<int> number = new NumberAndPosition<int>();

                if (char.IsDigit( s[i]))
                {
                    number.Position = i;
                    string numAsString = "";

                    while (char.IsDigit(s[i]))
                    {
                        numAsString += s[i];
                        i++;

                        if (i >= s.Length)
                            break;
                    }

                    number.Value = int.Parse(numAsString);
                    numsResult.Add(number);
                }

            }

            return numsResult;
        }

        public class NumberAndPosition<T>
        {
            public T Value;
            public int Position;

            public NumberAndPosition(T value, int position)
            {
                Value = value;
                Position = position;
            }

            public NumberAndPosition()
            {
                Value = default;
                Position = -1;
            }
        }
    }
}
