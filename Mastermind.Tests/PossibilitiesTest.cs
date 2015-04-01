using System;
using System.Linq;
using NUnit.Framework;

namespace Mastermind.Test
{
    [TestFixture]
    public class  PossibilitiesTest
    {

        [Test]
        public void RemovesGuessFromPossiblities()
        {
            TestElimination(new Possibilities("11", "12"), "11", new Score("B"), p =>
                {
                    Assert.IsTrue(p.GetPossibilities().Contains("12"));
                    Assert.AreEqual(1, p.GetPossibilities().Count());
                }
            );
        }

        [Test]
        public void RemovesAllPossibilitiesIfAllBlackPegs()
        {
            TestElimination(new Possibilities("11", "12"), "11", new Score("BB"), p =>
                {
                    Assert.IsTrue(p.Contains("11"));
                    Assert.AreEqual(1, p.Count());
                }
            );

            TestElimination(new Possibilities("111", "122"), "111", new Score("BBB"), p =>
                {
                    Assert.IsTrue(p.Contains("111"));
                    Assert.AreEqual(1, p.Count());
                }
            );
        }

        static void TestElimination(Possibilities possibilities, string guess, Score score, Action<Possibilities> assertion)
        {
            possibilities.EliminatePossibilities(guess, score);
            assertion.Invoke(possibilities);
        }
    }
}
