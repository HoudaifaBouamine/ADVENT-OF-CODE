using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions.SolutionTemplet
{
    public class ProblemGenerator
    {
        public bool Create(string ProblemName)
        {

            string PathOfFolder             = $"../../../Solutions/{ProblemName}";
            string PathOfCodeFile           = PathOfFolder + $"/{ProblemName}.cs";
            string PathOfCodeTempletFile    = $"../../../Solutions/SolutionTemplet/{nameof(ProblemTempletClassName)}.cs";
            string PathOfInputFile          = PathOfFolder + $"/{ProblemName}Input.txt";
            string PathOfOutputFile         = PathOfFolder + $"/{ProblemName}Output.txt";

            if (Directory.Exists(PathOfFolder))
            {
                Console.WriteLine($"{ProblemName} folder allready exist");
                return false;
            }

            Directory.CreateDirectory(PathOfFolder);
            File.Create(PathOfCodeFile).Close();

            string ProblemTempletCode = File.ReadAllText(PathOfCodeTempletFile);
            ProblemTempletCode = ProblemTempletCode.Replace(nameof(ProblemTempletClassName), ProblemName);
            File.WriteAllText(PathOfCodeFile,ProblemTempletCode);
            
            File.Create(PathOfInputFile).Close();
            File.WriteAllText(PathOfInputFile, "Please Run" );
            File.Create(PathOfOutputFile);

            return true;
        }
    }
}
