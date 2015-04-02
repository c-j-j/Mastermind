using System.Linq;
using System;

namespace Mastermind
{
    public class Game
    {
        CodeMaker codeMaker;

        CodeBreaker codeBreaker;

        public Game(CodeMaker codeMaker, CodeBreaker codeBreaker)
        {
            this.codeBreaker = codeBreaker;
            this.codeMaker = codeMaker;
        }

        public bool Run()
        {
            var possiblities = new Possibilities(Permutation.Generate(4, "1", "2", "3", "4", "5", "6").ToArray());
            codeMaker.SetCode(possiblities);
            Console.WriteLine("SelectedCode = " + codeMaker.SelectedCode);
            string guess = codeBreaker.GuessCode(possiblities, codeMaker);
            return guess == codeMaker.SelectedCode;
        }
    }
}
