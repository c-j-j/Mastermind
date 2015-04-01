using System;
using System.Collections.Generic;
using Negamax;

namespace Mastermind
{
    public class CodeBreaker
    {
        public string GuessCode(Possibilities possibilities, CodeMaker codeMaker)
        {
            for (int i = 0; i < 5; i++)
            {
                var guess = new CodeGuesser(new HitCountCalculator()).GetNextGuess(possibilities);
                var score = new ScoreCalculator().GetScore("2134", guess);
                if (score.NumberOfBlackPegs == 4)
                {
                    return guess;
                }

                possibilities.EliminatePossibilities(guess, score);
            }

            return "NOT FOUND";
        }
    }
}
