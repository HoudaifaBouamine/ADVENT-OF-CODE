using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    public class Problem1 : IProblem
    {
        public string InputFileName => nameof(Problem1) + ".txt";

        public string GetSolution(string Input)
        {
            string[] lines = Input.Split('\n');
            int Result = 0;

            foreach (string line in lines)
            {
                int Num2Digits = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsDigit(line[i]))
                    {
                        Num2Digits += (int.Parse( line[i].ToString() )) * 10;
                        break;
                    }
                }

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    if (char.IsDigit(line[i]))
                    {
                        Num2Digits += (int.Parse(line[i].ToString()));
                        break;
                    }
                }

                Result += Num2Digits;
            }

            return Result.ToString();
        }
    }
}
