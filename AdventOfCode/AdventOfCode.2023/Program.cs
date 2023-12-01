using AdventOfCode._2023.Solutions;

void Solution(IProblem problem)
{
    string input = File.ReadAllText($"../../../Solutions/{problem.SolutionFolderName}/{problem.InputFileName}");
    string output = problem.GetSolution(input!);


    File.WriteAllText($"../../../Solutions/{problem.SolutionFolderName}/{problem.OutputFileName}", output);
    Console.WriteLine(output);
}

Solution(new Problem1());