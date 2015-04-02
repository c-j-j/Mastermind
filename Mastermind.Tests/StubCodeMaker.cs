namespace Mastermind.Test
{
    public class StubCodeMaker : CodeMaker
    {

        public StubCodeMaker(string code)
        {
            SelectedCode = code;
        }

        public void SetCode(Possibilities possibilities)
        {
        }

        public Score GetScore(string guess)
        {
            return new ScoreCalculator().GetScore(SelectedCode, guess);
        }

        public string SelectedCode
        {
            get; private set;
        }
    }
}
