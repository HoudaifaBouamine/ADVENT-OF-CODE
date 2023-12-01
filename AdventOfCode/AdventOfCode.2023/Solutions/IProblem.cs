using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    internal interface IProblem
    {
        string GetSolution(string Input);
        string InputFileName { get; }
    }
}
