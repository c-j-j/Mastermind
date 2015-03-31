using NUnit.Framework;

namespace Mastermind.Test
{
    [TestFixture]
    public class HitCountCalculatorTest
    {
        [Test]
        public void EmptyWithNoHitCount()
        {
            var hitCount = GeHitCount(new Possibilities(), "");
            Assert.AreEqual(0, hitCount);
        }

        [Test]
        public void GuessWithOneHit()
        {
            Assert.AreEqual(1, GeHitCount(new Possibilities("ABCD"), "A"));
            Assert.AreEqual(1, GeHitCount(new Possibilities("ABCD"), "D"));
        }

        [Test]
        public void GuessWithMultipleHits()
        {
            Assert.AreEqual(2, GeHitCount(new Possibilities("ABCD", "ADFG"), "D"));
        }

        static int GeHitCount(Possibilities p, string guess)
        {
            return new HitCountCalculator().Calculate(new GuessWithPossiblities(p, guess));
        }
    }
}
