namespace Mastermind
{
    public class MainClass
    {
        public static void Main()
        {
            new Game(new ComputerCodeMaker(new ScoreCalculator()),
                    new CodeBreaker(new CodeGuesser(new HitCountCalculator()))).Run();
        }
    }
}
