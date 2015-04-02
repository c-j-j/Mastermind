namespace Mastermind
{
    public class MainClass
    {
        public static void Main()
        {
            new Game(new ComputerCodeMaker("5423", new ScoreCalculator()),
                    new ComputerCodeBreaker(new NegamaxCodeGuesser(new HitCountCalculator()))).Run();
        }
    }
}
