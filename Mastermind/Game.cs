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
            var possiblities = new Possibilities("1234", "2134", "2156", "2111", "1235", "1236", "1237");
            codeMaker.SelectCode(possiblities);

            string guess = codeBreaker.GuessCode(possiblities, codeMaker);
            return guess == codeMaker.SelectedCode;
        }
    }
}
