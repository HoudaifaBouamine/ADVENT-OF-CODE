using AdventOfCode._2023.Solutions;

void Solution(IProblem problem)
{
    string input = File.ReadAllText($"../../../Inputs/{problem.GetType()}.txt");
    string output = problem.GetSolution(input!);

    
    File.WriteAllText($"../../../Outputs/{problem.GetType()}.txt", output);
    Console.WriteLine(output);
}

Solution(new Problem1());