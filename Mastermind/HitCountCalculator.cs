namespace Mastermind
{
    public class HitCountCalculator
    {
        public int Calculate(GuessWithPossiblities guessWithPossibilities)
        {
            var hits = 0;
            foreach (var possibility in guessWithPossibilities.Possibilities.GetPossibilities())
            {
                if (GuessIsAHit(possibility, guessWithPossibilities.Guess))
                {
                    hits++;
                }
            }
            return hits;
        }

        private bool GuessIsAHit(string possibility, string guess)
        {
            return possibility.IndexOfAny(guess.ToCharArray()) != -1;
        }
    }
}
