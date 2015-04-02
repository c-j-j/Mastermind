namespace Mastermind
{
    public interface ICodeGuesser
    {
        string GetNextGuess(Possibilities possibilities);
    }
}
