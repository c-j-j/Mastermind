using System.Linq;

namespace Mastermind
{
    public class Score
    {
        public Score()
            : this(0, 0)
        {
        }

        public Score(string score) :this(score.Count(s => s=='B'), score.Count(s => s == 'W'))
        {
        }

        public Score(int numberOfBlackPegs, int numberOfWhitePegs)
        {
            NumberOfBlackPegs = numberOfBlackPegs;
            NumberOfWhitePegs = numberOfWhitePegs;
        }

        public int NumberOfBlackPegs
        {
            get;
            private set;
        }

        public int NumberOfWhitePegs
        {
            get;
            private set;
        }

        public void AddBlackPeg()
        {
            NumberOfBlackPegs++;
        }

        public void AddWhitePeg()
        {
            NumberOfWhitePegs++;
        }

        public bool EqualTo(Score s2)
        {
            if (NumberOfBlackPegs != s2.NumberOfBlackPegs)
            {
                return false;
            }
            if (NumberOfWhitePegs != s2.NumberOfWhitePegs)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
