using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode._2023.Solutions;
using AdventOfCode._2023.Solutions.Util;

namespace AdventOfCode._2023.Solutions
{
    public class Problem5 : IProblem
    {
        public Problem5()
        {
            InputFileName = nameof(Problem5) + "Input.txt";
            OutputFileName = nameof(Problem5) + "Output.txt";
            SolutionFolderName = nameof(Problem5);
        }
        public string InputFileName { get; }

        public string OutputFileName { get; }

        public string SolutionFolderName { get; }

        public string GetSolution(string Input)
        {
            var engine = new Engine(Input);

            int Sum = engine.SumOfValiedPartes();

            return Sum.ToString();
        }

        public class Engine
        {
            public List<string> Schema = null!;
            public List<List<StringManip.NumberAndPosition<int>>> Partes { get; } = new List<List<StringManip.NumberAndPosition<int>>>();

            public Engine(string SchemaAsString)
            {
                Schema = SchemaAsString.Split(Environment.NewLine).
                Where(l => !string.IsNullOrEmpty(l))
                .ToList();

                foreach (var schemaLine in Schema)
                {
                    Partes.Add(StringManip.GetIntegersFromString(schemaLine));
                }
            }

            public int SumOfValiedPartes()
            {
                int Sum = 0;
                List<List<StringManip.NumberAndPosition<int>>> valied = new List<List<StringManip.NumberAndPosition<int>>>();

                for(int line = 0;line<Partes.Count;line++)
                {
                   foreach(var part in Partes[line])
                    {
                        if (IsValiedPart(part,line))
                        {
                            Sum += part.Value;
                        }
                    }
                }

                return Sum;
            }

            private bool IsValiedPart(StringManip.NumberAndPosition<int> part,int Line)
            {

                Point PartPosition = new Point(part.Position,Line);
                int PartLength = part.Value.ToString().Length;
                
                for(int colmOffset = -1; colmOffset < PartLength + 1;colmOffset++)
                {
                    int rowOffSet = -1;

                    if(CheckPos(PartPosition.X + colmOffset, PartPosition.Y + rowOffSet))
                    {
                        return true;
                    }

                    rowOffSet = 1;

                    if (CheckPos(PartPosition.X + colmOffset, PartPosition.Y + rowOffSet))
                    {
                        return true;
                    }
                    
                }

                if(CheckPos(PartPosition.X - 1, PartPosition.Y))
                {
                    return true;
                }

                if(CheckPos(PartPosition.X + PartLength, PartPosition.Y))
                {
                    return true;
                }

                

                return false;
            }
            private bool CheckPos(int x, int y)
            {
                if (x >= 0
                    && x < Schema[0].Length
                    && y >= 0
                    && y < Schema.Count)
                {
                    if (Schema[y][x] != '.')
                    {
                        return true;
                    }
                }

                return false;
            }

        }
    }
}
