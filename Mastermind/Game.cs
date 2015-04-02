using System.Linq;
using System;

namespace Mastermind
{
    public class Game
    {
        readonly CodeMaker codeMaker;
        readonly ComputerCodeBreaker codeBreaker;

        public Game(CodeMaker codeMaker, ComputerCodeBreaker codeBreaker)
        {
            this.codeBreaker = codeBreaker;
            this.codeMaker = codeMaker;
        }

        public bool Run()
        {
            Console.WriteLine("SelectedCode = " + codeMaker.SelectedCode);
            return HasCodeBreakerGuessedCorrectly(GetGuessFromCodeBreaker());
        }

        bool HasCodeBreakerGuessedCorrectly(string finalGuess)
        {
            return finalGuess == codeMaker.SelectedCode;
        }

        string GetGuessFromCodeBreaker()
        {
            return codeBreaker.GuessCode(BuildAllPossibilities(), codeMaker);
        }

        static Possibilities BuildAllPossibilities()
        {
            var variable = new Possibilities(Permutation.Generate(4, "1", "2", "3", "4", "5", "6").ToArray());
            return variable;
        }
    }
}
