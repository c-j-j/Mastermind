using System.Text;

namespace Mastermind
{
    public class ScoreCalculator
    {
       public Score GetScore(string actualAnswer, string guess)
       {
            var score = new Score();
            var code = new StringBuilder(actualAnswer);

            foreach (char guessedChar in guess)
            {
                var indexOfChar = FindIndexOfCharInCode(code, guessedChar);
                if (GuessedCharacterExistsInCode(indexOfChar))
                {
                    if(GuessHasCorrectLocation(guess, indexOfChar, guessedChar))
                    {
                        score.AddBlackPeg();

                    }else
                    {
                        score.AddWhitePeg();
                    }
                    removeGuessedCharacter(code, indexOfChar);
                }
            }
            return score;
       }

        void removeGuessedCharacter(StringBuilder code, int indexOfChar)
        {
            code[indexOfChar] = ' ';
        }

        bool GuessedCharacterExistsInCode(int indexOfChar)
        {
            return indexOfChar != -1;
        }

        private int FindIndexOfCharInCode(StringBuilder code, char characterToFind)
        {
            return code.ToString().IndexOf(characterToFind);
        }

        private bool GuessHasCorrectLocation(string guess, int indexOfGuessedChar, char guessedChar)
        {
            return  guess[indexOfGuessedChar].Equals(guessedChar);
        }


    }
}
