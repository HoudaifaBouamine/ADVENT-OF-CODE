using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    public class Problem3 : IProblem
    {
        public Problem3()
        {
            InputFileName = nameof(Problem3) + "Input.txt";
            OutputFileName = nameof(Problem3) + "Output.txt";
            SolutionFolderName = nameof(Problem3);
        }
        public string InputFileName { get; }

        public string OutputFileName { get; }

        public string SolutionFolderName { get; }

        public string GetSolution(string Input)
        {
            var games = Input.Split("\r\n");
            List<Game> gamesDetailes = new List<Game>();

            foreach (var game in games)
            {
                if(game != "")
                    gamesDetailes.Add(new Game(game));
            }

                int IdsSum = 0;

            foreach(var game in gamesDetailes)
            {

                if (game.IsPossible(12,13,14))
                {
                    IdsSum += game.Id;
                }
                
            }




            return IdsSum.ToString() ;
        }

        class Game
        {
            public int Id { get; set; }

            public List<Set> Sets { get; set; } = new List<Set>();

            public override string ToString()
            {
                string theString = "";
                theString += $"Game {Id}:\n";
                
                for(int i = 0; i < Sets.Count; i++)
                {
                    theString += "\t" + Sets[i].ToString() + "\n";
                }



                return theString + "\n";

            }

            public bool IsPossible(int red,int green,int blue)
            {
                foreach(var set in Sets)
                {
                    if(set.Red > red || set.Green > green || set.Blue > blue)
                    {
                        return false;
                    }
                }
                return true;
            }

            public class Set
            {
                public int Blue { get; set; } = 0;
                public int Red { get; set; } = 0;
                public int Green { get; set; } = 0;

                public override string ToString()
                {
                    string s = $"Blue : {Blue}, Red : {Red}, Green : {Green}";

                    return s;
                }
            }

            public Game(string game)
            {

                var id_and_detailes = game.Split(": ");

                this.Id = int.Parse(id_and_detailes[0].Split(" ")[1]);

                var setes = id_and_detailes[1].Split("; ");

                foreach(var set in setes)
                {
                    var coloresAndRepitstions = set.Split(", ");
                    Set theSet = new Set();
                    
                    foreach(var c in coloresAndRepitstions)
                    {
                        var numberAndColor = c.Split(" ");



                        if (numberAndColor[1] == "blue")
                        {
                            theSet.Blue = int.Parse(numberAndColor[0]);
                        }
                        else if (numberAndColor[1] == "red")
                        {
                            theSet.Red = int.Parse(numberAndColor[0]);
                        }
                        else if (numberAndColor[1] == "green")
                        {
                            theSet.Green = int.Parse(numberAndColor[0]);
                        }

                    }

                    Sets.Add(theSet);
                }
            }
        }
    }
}
