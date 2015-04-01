
using NUnit.Framework;

namespace Mastermind.Test
{

    [TestFixture]
    public class ScoreCalculatorTest
    {

        ScoreCalculator scoreCalculator;

        [SetUp]
        public void Setup()
        {
            scoreCalculator = new ScoreCalculator();
        }

        [Test]
        public void ProvidesOneWhitePeg()
        {
            Score score = scoreCalculator.GetScore("ABDC", "BXXX");
            Assert.AreEqual(1, score.NumberOfWhitePegs);
        }

        [Test]
        public void ProvidesTwoWhitePegs()
        {
            Score score = scoreCalculator.GetScore("ABDC", "BCXX");
            Assert.AreEqual(2, score.NumberOfWhitePegs);
        }

        [Test]
        public void ProvidesOneBlackPeg()
        {
            Score score = scoreCalculator.GetScore("ABDC", "AXXX");
            Assert.AreEqual(1, score.NumberOfBlackPegs);
        }

        [Test]
        public void ProvidesTwoBlackPegs()
        {
            Score score = scoreCalculator.GetScore("ABDC", "ABXX");
            Assert.AreEqual(2, score.NumberOfBlackPegs);
        }

        [Test]
        public void ProvidesSingleWhitePegForDuplicate()
        {
            Score score = scoreCalculator.GetScore("ABDC", "XXAA");
            Assert.AreEqual(1, score.NumberOfWhitePegs);
        }

        [Test]
        public void ProvidesSingleBlackPegForDuplicate()
        {
            Score score = scoreCalculator.GetScore("ABDC", "AAXX");
            Assert.AreEqual(1, score.NumberOfBlackPegs);
        }

        [Test]
        public void SelectedCodeWithDuplicate()
        {
            Score score = scoreCalculator.GetScore("ABDC", "XXAX");
            Assert.AreEqual(1, score.NumberOfWhitePegs);
        }

    }
}
