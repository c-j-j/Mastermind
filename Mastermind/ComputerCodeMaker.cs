using System;
using System.Linq;

namespace Mastermind
{
    public class ComputerCodeMaker : CodeMaker
    {
        ScoreCalculator scoreCalculator;

        public ComputerCodeMaker(string selectedCode, ScoreCalculator scoreCalculator)
        {
            this.scoreCalculator = scoreCalculator;
            SelectedCode = selectedCode;
        }

        public ComputerCodeMaker(ScoreCalculator scoreCalculator)
        {
            this.scoreCalculator = scoreCalculator;
        }

        public void SetCode(Mastermind.Possibilities possibilities)
        {
            //int randomIndex = new Random().Next(possibilities.Count());
            //SelectedCode = possibilities.GetPossibilities().ElementAt(randomIndex);
        }

        public Score GetScore(string guess)
        {
            return scoreCalculator.GetScore(SelectedCode, guess);
        }

        public string SelectedCode
        {
            get;
            private set;
        }

    }
}
