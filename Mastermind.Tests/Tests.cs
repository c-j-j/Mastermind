using System.Collections.Generic;
using NUnit.Framework;

namespace Mastermind.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void CorrectGuessTerminates()
        {
            var possibilities = new HashSet<string>
            {
                {"1234"}
            };

            Assert.AreEqual("1234", new CodeBreaker().FindNextGuess(possibilities));
        }

        [Test]
        public void TwoOptions()
        {
            var possibilities = new HashSet<string>
            {
                {"1234"}, {"1235"}
            };

            Assert.AreEqual("1234", new CodeBreaker().FindNextGuess(possibilities));
        }
    }
}
