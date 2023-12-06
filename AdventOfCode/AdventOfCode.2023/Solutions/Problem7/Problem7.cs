using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    public class Problem7 : IProblem
    {
        public Problem7()
        {
            InputFileName = nameof(Problem7) + "Input.txt";
            OutputFileName = nameof(Problem7) + "Output.txt";
            SolutionFolderName = nameof(Problem7);
        }
        public string InputFileName { get; }

        public string OutputFileName { get; }

        public string SolutionFolderName { get; }

        public string GetSolution(string Input)
        {
            CardesNumbers cardesNumbers = new CardesNumbers(Input);

           return cardesNumbers.GetTotalPointes().ToString();
        }

        public class CardesNumbers
        {
            public CardesNumbers(string input)
            {
                var lines = input.Split(Environment.NewLine);

                foreach(var line in lines)
                    if(line != "")
                        careds.Add(new CardNumbers(line));


            }

            public int GetTotalPointes()
            {
                int pointes = 0;
                foreach(var card in careds)
                {
                    pointes += card.GetPoints();
                }
                return pointes;
            }

            List<CardNumbers> careds = new List<CardNumbers>();
            public class CardNumbers
            {
                public CardNumbers(string gameAsString)
                {
                    string numbers = gameAsString.Split(": ")[1];

                    var numbersWin_YouHave = numbers.Split(" | ");

                    var numbersWin = numbersWin_YouHave[0].Split(" ");
                    var numbersYouHave = numbersWin_YouHave[1].Split(" ");

                    foreach(var num in numbersWin)
                    {
                        if(num != "")
                            NumbersWin.Add(int.Parse(num.Trim()));
                    }

                    foreach(var num in numbersYouHave)
                    {
                        if(num != "") 
                            NumbersYouHave.Add(int.Parse(num.Trim()));
                    }
                }

                List<int> NumbersYouHave = new List<int>();
                List<int> NumbersWin = new List<int>();

                public int GetPoints()
                {
                    int accure = 0;
                    foreach(var num in NumbersYouHave)
                    {
                        if (NumbersWin.Contains(num))
                        {
                            accure++;
                        }
                    }

                    int pointes = 0;

                    if(accure > 0)
                        pointes = (int)Math.Pow(2, accure - 1);

                    return pointes;
                }
            }

        }
        
    }
}
    