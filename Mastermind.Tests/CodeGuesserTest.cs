using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Mastermind.Tests
{
    [TestFixture]
    public class CodeGuesserTest
    {
        CodeGuesser codeGuesser;
        Possibilities possibilities;
        HitCountCalculator hitCountCalculator;

        [SetUp]
        public void Setup(){
            hitCountCalculator = new HitCountCalculator();
            codeGuesser = new CodeGuesser(hitCountCalculator);
            possibilities = new Possibilities("1234");
        }


        [Test]
        public void CorrectGuessTerminates()
        {
            Assert.AreEqual("1234", codeGuesser.GetNextGuess(possibilities));
        }

        [Test]
        public void TerminalPredicateWhenGuessExists()
        {
            Assert.AreEqual(true, codeGuesser.IsGuessPresent(new GuessWithPossiblities(possibilities, "guess")));
            Assert.AreEqual(false, codeGuesser.IsGuessPresent(GuessWithPossiblities.NoGuess(possibilities)));
        }

        [Test]
        public void ProducesCollectionOfGuessesForEveryPossibility()
        {
            var possibilitiesForEachGuess = codeGuesser.GetPossibilities(GuessWithPossiblities.NoGuess(possibilities));
            Assert.AreEqual(possibilities.GetPossibilities().First(), possibilitiesForEachGuess.First().Guess);
            Assert.AreEqual(possibilities, possibilitiesForEachGuess.First().Possibilities);
        }

        [Test]
        public void HitCountCalculationIsDelagated()
        {
            var guess = new GuessWithPossiblities(possibilities, "1234");
            var hitCount = codeGuesser.GetHitCount(guess);
            Assert.AreEqual(hitCountCalculator.Calculate(guess), hitCount);
        }
    }
}
