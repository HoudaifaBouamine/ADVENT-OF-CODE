using AdventOfCode._2023.Solutions;
using AdventOfCode._2023.Solutions.SolutionTemplet;

void Solution(IProblem problem)
{
    string input = File.ReadAllText($"../../../Solutions/{problem.SolutionFolderName}/{problem.InputFileName}");
    string output = problem.GetSolution(input!);


    File.WriteAllText($"../../../Solutions/{problem.SolutionFolderName}/{problem.OutputFileName}", output);
    Console.WriteLine(output);
}

//Solution(new Problem1());

void CreateProblemFolder(string ProblemName)
{
    ProblemGenerator problemGenerator = new ProblemGenerator();

    problemGenerator.Create(ProblemName);
}

CreateProblemFolder("Problem2");