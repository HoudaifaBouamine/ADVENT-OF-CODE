using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return $"Problem : '{nameof(Problem2)}' is not emplimented yet";
        }
    }
}
