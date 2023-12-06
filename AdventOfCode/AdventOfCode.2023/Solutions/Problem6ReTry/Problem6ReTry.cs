using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    public class Problem6ReTry : IProblem
    {
        public Problem6ReTry()
        {
            InputFileName = nameof(Problem6ReTry) + "Input.txt";
            OutputFileName = nameof(Problem6ReTry) + "Output.txt";
            SolutionFolderName = nameof(Problem6ReTry);
        }
        public string InputFileName { get; }

        public string OutputFileName { get; }

        public string SolutionFolderName { get; }

        public string GetSolution(string Input)
        {
            var Lines = Input.Split(Environment.NewLine);
            for(int i = 0;i < Lines.Length; i++)
            {
                for(int j = 0; j < Lines[i].Length;j++) 
                {
                    if (Lines[i][j] == '*')
                    {
                        var numbs = new List<int>();
                        for(int k = -1; k <= 1; k++)
                        {
                            for(int l = -1; l <= 1; l++)
                            {
                                if(k != 0 || l != 0)
                                {
                                    if (i + k >= 0 && i + l < Lines.Length && j + l >= 0 && j + l < Lines[0].Length)
                                    {
                                        if (char.IsDigit(Lines[i + k][j + l]))
                                        {
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return "Not Implimented yet";

        }
    }
}
