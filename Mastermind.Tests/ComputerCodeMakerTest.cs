using NUnit.Framework;

namespace Mastermind.Test
{
    [TestFixture]
    public class ComputerCodeMakerTest
    {
        ComputerCodeMaker codeMaker;
        ScoreCalculator scoreCalculator;
        Possibilities possibilities = new Possibilities("a", "b", "c");

        [SetUp]
        public void Setup()
        {
            scoreCalculator = new ScoreCalculator();
            codeMaker = new ComputerCodeMaker(scoreCalculator);
        }

        [Test]
        public void SelectsRandomCode()
        {
            codeMaker.SetCode(possibilities);
            CollectionAssert.Contains(possibilities.GetPossibilities(), codeMaker.SelectedCode);
        }

        [Test]
        public void ScoreIsDelegatedToScoreCalculator()
        {
            var codeMaker = new ComputerCodeMaker("5", scoreCalculator);
            Assert.AreEqual(scoreCalculator.GetScore("5", "5").NumberOfBlackPegs, codeMaker.GetScore("5").NumberOfBlackPegs);
        }
    }
}
