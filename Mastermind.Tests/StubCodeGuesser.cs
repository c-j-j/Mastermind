namespace Mastermind.Test
{
    public class StubCodeGuesser : ICodeGuesser
    {

        readonly string guess;

        public StubCodeGuesser(string guess)
        {
            this.guess = guess;
        }

        public string GetNextGuess(Possibilities possibilities){
            return guess;
        }
    }
}
