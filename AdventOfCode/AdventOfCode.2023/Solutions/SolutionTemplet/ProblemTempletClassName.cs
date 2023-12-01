using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    public class ProblemTempletClassName : IProblem
    {
        public ProblemTempletClassName()
        {
            InputFileName = nameof(ProblemTempletClassName) + "Input.txt";
            OutputFileName = nameof(ProblemTempletClassName) + "Output.txt";
            SolutionFolderName = nameof(ProblemTempletClassName);
        }
        public string InputFileName { get; }

        public string OutputFileName { get; }

        public string SolutionFolderName { get; }

        public string GetSolution(string Input)
        {
            return $"Problem : '{nameof(ProblemTempletClassName)}' is not emplimented yet";
        }
    }
}
