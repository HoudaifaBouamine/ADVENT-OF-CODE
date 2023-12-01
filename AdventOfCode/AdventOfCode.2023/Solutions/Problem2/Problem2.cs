using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    public class Problem2 : IProblem
    {
        public Problem2()
        {
            InputFileName = nameof(Problem2) + "Input.txt";
            OutputFileName = nameof(Problem2) + "Output.txt";
            SolutionFolderName = nameof(Problem2);
        }
        public string InputFileName { get; }

        public string OutputFileName { get; }

        public string SolutionFolderName { get; }

        public string GetSolution(string Input)
        {

            string[] Lines = Input.Split("\n");

            int Result = 0;

            foreach(string Line in Lines) 
            {
                int DigitLeft  = 0;
                int DigitRight = 0;
                
                for(int i = 0; i < Line.Length; i++)
                {

                    if (IsDigit(Line, i, out DigitLeft))
                    {
                        break;
                    }
                }

                for(int i = Line.Length-1; i >= 0; i--)
                {

                    if (IsDigit(Line, i, out DigitRight))
                    {
                        break;
                    }
                }


                Console.WriteLine($"Num : {DigitRight + DigitLeft * 10}");

                Result += DigitRight + DigitLeft * 10;

            }
            
            return Result.ToString();
        }

        private string[] digits = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "one", "two", "three", "four", "five", "six", "seven", "eight","nine"};
        private bool IsDigit(string Input,int StartIndex,out int digit)
        {
            string MayBeDigit = Input.Substring(StartIndex, Math.Min( 5, Input.Length - StartIndex ));

            for (int i = 0;i < digits.Length;i++)
            {
                if (MayBeDigit.IndexOf(digits[i]) == 0) 
                {
                    digit = i % 9 + 1;
                    return true;
                } 
            }

            digit = -1;
            return false;
        }

        //private List<string> GetAllSubstrings(string String)
        //{
        //    List<string> SubStrings = new List<string>();
        //    for (int i = 1; i <= String.Length; i++)
        //    {
        //        for (int j = 0; j <= String.Length - i; j++)
        //        {
        //            SubStrings.Add(String.Substring(j, i));
        //        }
        //    }
        //    return SubStrings; 
        //}

    }
}
