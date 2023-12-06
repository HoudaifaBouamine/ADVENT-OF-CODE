using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    public class Problem6 : IProblem
    {
        public Problem6()
        {
            InputFileName = nameof(Problem6) + "Input.txt";
            OutputFileName = nameof(Problem6) + "Output.txt";
            SolutionFolderName = nameof(Problem6);
        }
        public string InputFileName { get; }

        public string OutputFileName { get; }

        public string SolutionFolderName { get; }

        public string GetSolution(string Input)
        {
            EngineWithGears engineWithGears = new EngineWithGears(Input);
            int sum = engineWithGears.SumOfGearsPowers();

            return sum.ToString();
        }

        public class EngineWithGears : Problem5.Engine
        {
            public EngineWithGears(string SchemaAsString) : base(SchemaAsString)
            {

            }

            public int SumOfGearsPowers()
            {
                int Sum = 0;

                for(int i = 0 ; i < Schema.Count; i++)
                {
                    for(int j = 0 ; j < Schema[0].Length; j++)
                    {
                        List<int> num = new List<int>();
                        if(Schema[i][j] == '*')
                        {
                            for(int k = -1; k <= 1; k++)
                            {
                                for(int m = -1; m <= 1; m++)
                                {
                                    if(m != 0 && k != 0)
                                    {
                                        int number = CheckPoint(i + k, j + m);

                                        if(number == -1)
                                        {
                                            continue;
                                        }

                                        num.Add(number);
                                    }
                                }
                            }
                        }

                        if(num.Count == 2)
                        {
                            Sum += num[0] * num[1];
                        }
                    }
                }

                return Sum;

                int CheckPoint(int row,int colm)
                {
                    if(!(row >= 0 && colm >= 0 && row < Schema.Count && colm < Schema[0].Length))
                    {
                        return -1;
                    }

                    if (char.IsDigit(Schema[row][colm]))
                    {
                        if(row == 93 && colm == 118)
                        {
                            int y = 0;
                        }

                        int colmOffset = 0;
                        
                        while(colmOffset + colm >= 0 && char.IsDigit( Schema[row][colm + colmOffset]))
                        {
                            colmOffset--;
                        }


                        if (colmOffset + colm < 0)
                        {
                            colmOffset++;
                        }
                        else if (Schema[row][colm + colmOffset] != '-')
                        {
                            colmOffset++;
                        }
                        

                        string NumAsString = "";
                        while(colmOffset + colm < Schema[0].Length && char.IsDigit(Schema[row][colm + colmOffset]))
                        {
                            NumAsString += Schema[row][colm + colmOffset];
                            colmOffset++;
                        }

                        //colmOffset--;

                        int number = int.Parse(NumAsString);

                        if (NumAsString == "703" || NumAsString == "-703")
                        {
                            int c = 1;
                        }

                        return number;
                    }

                    return -1;
                }

            }

        }
    }
}
