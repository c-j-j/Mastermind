using System;
using System.Linq;
using System.Collections.Generic;
using Negamax;

namespace Mastermind
{
    public class CodeBreaker
    {
        const int MAX_TRIES = 10;

        ICodeGuesser codeGuesser;
        public CodeBreaker(ICodeGuesser codeGuesser)
        {
            this.codeGuesser = codeGuesser;
        }

        public string GuessCode(Possibilities possibilities, CodeMaker codeMaker)
        {
            for (int i = 0; i < MAX_TRIES; i++)
            {
                var guess = GetNextGuess(possibilities);
                var score = PlayGuess(codeMaker, guess);
                Console.WriteLine(guess);
                Console.WriteLine(score);

                if (score.NumberOfBlackPegs == 4)
                {
                    return guess;
                }
                else
                {
                    //Console.WriteLine(string.Join(",", possibilities.GetPossibilities()));
                    //Console.WriteLine("----------------");
                    //Console.WriteLine("Poss before = " + possibilities.Count());
                    possibilities.EliminatePossibilities(guess, score);
                    //Console.WriteLine("Poss after = " + possibilities.Count());
                }
            }

            return "NOT FOUND";
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
