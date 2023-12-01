using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    public class Problem1 : IProblem
    {
        public Problem1()
        {
            InputFileName      = nameof(Problem1) + "Input.txt";
            OutputFileName     = nameof(Problem1) + "Output.txt";
            SolutionFolderName = nameof(Problem1);
        }
        public string InputFileName { get; }

        public string OutputFileName { get; }

        public string SolutionFolderName { get; }

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
                        Num2Digits += int.Parse(line[i].ToString()) * 10;
                        break;
                    }
                }

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    if (char.IsDigit(line[i]))
                    {
                        Num2Digits += int.Parse(line[i].ToString());
                        break;
                    }
                }

                Result += Num2Digits;
            }

            return Result.ToString();
        }
    }
}
