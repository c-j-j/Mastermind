using System.Collections.Generic;
using Negamax;
using System.Linq;

namespace Mastermind
{
    public class CodeGuesser : ICodeGuesser
    {
        HitCountCalculator hitCountCalculator;

        public CodeGuesser(HitCountCalculator HitCountCalculator)
        {
            this.hitCountCalculator = HitCountCalculator;

        }
        public string GetNextGuess(Possibilities possibilities)
        {
            var negamaxCalculator = new Negamax.NegamaxCalculator<GuessWithPossiblities>(IsGuessPresent, GetHitCount, GetPossibilities);
            return negamaxCalculator.Negamax(GuessWithPossiblities.NoGuess(possibilities)).Node.Guess;
        }

        public bool IsGuessPresent(GuessWithPossiblities guess)
        {
            return guess.IsGuessPresent();
        }

        public int GetHitCount(GuessWithPossiblities guess)
        {
            return hitCountCalculator.Calculate(guess);
        }

        public IEnumerable<GuessWithPossiblities> GetPossibilities(GuessWithPossiblities guess)
        {
            var possibilities = guess.Possibilities;
            return possibilities.GetPossibilities().Select(g => new GuessWithPossiblities(possibilities, g));
        }
    }
}
