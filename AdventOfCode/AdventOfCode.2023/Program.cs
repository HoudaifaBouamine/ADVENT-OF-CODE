using AdventOfCode._2023.Solutions;
using AdventOfCode._2023.Solutions.SolutionTemplet;

void Solution(IProblem problem)
{
    string input = File.ReadAllText($"../../../Solutions/{problem.SolutionFolderName}/{problem.InputFileName}");
    string output = problem.GetSolution(input!);

    Console.WriteLine(output);
    File.WriteAllText($"../../../Solutions/{problem.SolutionFolderName}/{problem.OutputFileName}", output);
}

Solution(new Problem3());

void CreateProblemFolder(string ProblemName)
{
    ProblemGenerator problemGenerator = new ProblemGenerator();

    problemGenerator.Create(ProblemName);
}

//CreateProblemFolder("Problem3");


