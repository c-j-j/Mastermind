namespace Mastermind
{
    public class GuessWithPossiblities
    {
        public GuessWithPossiblities(Possibilities possibilities, string guess)
        {
            Guess = guess;
            Possibilities = possibilities;
        }

        public Possibilities Possibilities
        {
            get; set;
        }

        public string Guess
        {
            get; set;
        }

        public static GuessWithPossiblities NoGuess(Possibilities possibilities)
        {
            return new GuessWithPossiblities(possibilities, null);
        }

        public bool IsGuessPresent()
        {
            return Guess != null;
        }
    }
}
