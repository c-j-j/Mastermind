using System;
using System.Collections.Generic;
using System.Linq;

namespace Mastermind
{
    public class Possibilities
    {
        readonly HashSet<string> possibilities;

        public Possibilities(params string[] possibilities)
        {
            this.possibilities = new HashSet<string>(possibilities);
        }

        public IEnumerable<string> GetPossibilities()
        {
            return possibilities;
        }

        public bool Contains(string s)
        {
            return possibilities.Contains(s);
        }

        public int Count()
        {
            return possibilities.Count();
        }

        public void EliminatePossibilities(string guess, Score score)
        {
            var possibilitiesToEliminate = new HashSet<string>();

            foreach (var possibility in possibilities)
            {
                if (CanPossibilityBeEliminated(score, GetScore(guess, possibility)))
                {
                    possibilitiesToEliminate.Add(possibility);
                }
            }

            RemovePossibilities(possibilitiesToEliminate);
        }

        bool CanPossibilityBeEliminated(Score scoreOfGuess, Score scoreOfPossibilityWRTGuess)
        {
            return !scoreOfGuess.EqualTo(scoreOfPossibilityWRTGuess);
        }

        void RemovePossibilities(HashSet<string> possibilitiesToEliminate)
        {
            possibilities.RemoveWhere(possibilitiesToEliminate.Contains);
        }

        Score GetScore(string guess, string possibility)
        {
            return new ScoreCalculator().GetScore(guess, possibility);
        }

    }
}
