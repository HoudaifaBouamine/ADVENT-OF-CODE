using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Solutions
{
    public class Problem4 : IProblem
    {
        public Problem4()
        {
            InputFileName = nameof(Problem4) + "Input.txt";
            OutputFileName = nameof(Problem4) + "Output.txt";
            SolutionFolderName = nameof(Problem4);
        }
        public string InputFileName { get; }

        public string OutputFileName { get; }

        public string SolutionFolderName { get; }

        public string GetSolution(string Input)
        {
            var games = Game.ToGameList(Input);

            int SumOfMinimumSetsPowers = 0;

            foreach(var game in games)
            {
                SumOfMinimumSetsPowers += game.MinimumSetPower();
            }

            return SumOfMinimumSetsPowers.ToString() ;
        }

        public class Game : Problem3.Game 
        {

            public Game(string game) : base(game)
            {
                
            }

            public Set MinimumSet()
            {
                Set setResult = new Set();

                foreach(var set in Sets)
                {
                    if(set.Blue > setResult.Blue)
                    {
                        setResult.Blue = set.Blue;
                    }

                    if (set.Red > setResult.Red)
                    {
                        setResult.Red = set.Red;
                    }

                    if (set.Green > setResult.Green)
                    {
                        setResult.Green = set.Green;
                    }
                }

                return setResult;
            }

            public int MinimumSetPower()
            {
                var minSet = MinimumSet();
                return minSet.Blue * minSet.Red * minSet.Green;
            }
            static public List<Game> ToGameList(string gamesAsString)
            {
                var gamesAsStringList = gamesAsString.Split("\r\n");
                List<Game> games = new List<Game>();

                foreach (var game in gamesAsStringList)
                {
                    if(game != "")
                        games.Add(new Game(game));
                }

                return games;
            }
        }

    }
}
