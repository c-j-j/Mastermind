using System;

namespace Mastermind
{
    public class ComputerCodeBreaker
    {
        const int MAX_TRIES = 10;
        ICodeGuesser codeGuesser;

        public ComputerCodeBreaker(ICodeGuesser codeGuesser)
        {
            this.codeGuesser = codeGuesser;
        }

        public string GuessCode(Possibilities possibilities, CodeMaker codeMaker)
        {
            for (int i = 0; i < MAX_TRIES; i++)
            {
                var guess = GetNextGuess(possibilities);
                var score = PlayGuess(codeMaker, guess);

                if (GuessIsCorrect(score))
                {
                    return guess;
                }

                EliminatePossibilities(possibilities, guess, score);
            }

            return "NOT FOUND";
        }

        static void EliminatePossibilities(Possibilities possibilities, string guess, Score score)
        {
            possibilities.EliminatePossibilities(guess, score);
        }

        static bool GuessIsCorrect(Score score)
        {
            var variable = score.NumberOfBlackPegs == 4;
            return variable;
        }

        string GetNextGuess(Possibilities possibilities)
        {
            return codeGuesser.GetNextGuess(possibilities);
        }

        static Score PlayGuess(CodeMaker codeMaker, string guess)
        {
            return codeMaker.GetScore(guess);
        }
    }
}
