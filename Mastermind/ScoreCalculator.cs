using System;
using System.Linq;
using System.Text;

namespace Mastermind
{
    public class ScoreCalculator
    {
        const char NULL = '\0';

        public Score GetScore(string code, string guess)
        {
            var score = new Score();
            var guessChars = guess.ToCharArray();
            var codeChars = code.ToCharArray();

            PopulateScoreWithBlackPegs(guess, score, guessChars, codeChars);
            PopulateScoreWithWhitePegs(guess, score, guessChars, codeChars);
            return score;
        }

        static void PopulateScoreWithBlackPegs(string guess, Score score, char[] guessChars, char[] codeChars)
        {
            for (int i = 0; i < guess.Length; i++)
            {
                if (CorrectGuessInCorrectLocation(guessChars, codeChars, i))
                {
                    score.AddBlackPeg();
                    RemoveCharFromArray(guessChars, i);
                    RemoveCharFromArray(codeChars, i);
                }
            }
        }

        static void PopulateScoreWithWhitePegs(string guess, Score score, char[] guessChars, char[] codeChars)
        {
            for (int i = 0; i < guess.Length; i++)
            {
                if (guessChars[i] != NULL)
                {
                    var indexOfChar = FindIndex(codeChars, guessChars[i]);
                    if (CharacterFound(indexOfChar))
                    {
                        score.AddWhitePeg();
                        RemoveCharFromArray(guessChars, i);
                        RemoveCharFromArray(codeChars, indexOfChar);
                    }
                }
            }
        }

        static int FindIndex(char[] chars, char characterToFind)
        {
            return Array.IndexOf(chars, characterToFind);
        }

        static bool CorrectGuessInCorrectLocation(char[] guessChars, char[] codeChars, int index)
        {
            return guessChars[index] == codeChars[index];
        }

        static void RemoveCharFromArray(char[] guessChars, int indexToRemove)
        {
            guessChars[indexToRemove] = NULL;
        }

        static bool CharacterFound(int indexOfChar)
        {
            var variable = indexOfChar != -1;
            return variable;
        }

    }
}
