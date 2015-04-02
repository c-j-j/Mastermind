using System;
using NUnit.Framework;

namespace Mastermind.Test
{
    [TestFixture]
    public class CodeBreakerTest
    {

        CodeBreaker codeBreaker;

        [SetUp]
        public void Setup()
        {
            codeBreaker = new CodeBreaker(new CodeGuesser(new HitCountCalculator()));
        }

        [Test]
        public void AbleToGuessCodeWhenOnlySinglePossibilityExist()
        {
            var codeMaker = BuildCodeMaker("1234");
            var guess = codeBreaker.GuessCode(new Possibilities("1234"), codeMaker);
            Assert.AreEqual("1234", guess);
        }

        [Test]
        public void AbleToGuessCodeWhenMulitplePossibilitiesExist()
        {
            var codeMaker = BuildCodeMaker("1234");
            var guess = codeBreaker.GuessCode(new Possibilities("4321", "1232", "1233", "1234"), codeMaker);
            Assert.AreEqual("1234", guess);
        }

        static ComputerCodeMaker BuildCodeMaker(string code)
        {
            var codeMaker = new ComputerCodeMaker(code, new ScoreCalculator());
            return codeMaker;
        }
    }
}
