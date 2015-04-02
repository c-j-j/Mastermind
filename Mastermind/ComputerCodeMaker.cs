using System;
using System.Linq;

namespace Mastermind
{
    public class ComputerCodeMaker : CodeMaker
    {
        readonly ScoreCalculator scoreCalculator;

        public ComputerCodeMaker(string selectedCode, ScoreCalculator scoreCalculator)
        {
            this.scoreCalculator = scoreCalculator;
            SelectedCode = selectedCode;
        }

        public ComputerCodeMaker(ScoreCalculator scoreCalculator)
        {
            this.scoreCalculator = scoreCalculator;
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
