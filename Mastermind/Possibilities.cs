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
            var possibilitiesToRemove = new HashSet<string>();

            foreach (var possibility in possibilities)
            {
                var scoreForPossibility = new ScoreCalculator().GetScore(guess, possibility);
                Console.WriteLine(string.Format("score = {0}, possibility = {1}", scoreForPossibility, possibility));

                if (!score.EqualTo(scoreForPossibility))
                {
                    possibilitiesToRemove.Add(possibility);
                }
            }

            possibilities.RemoveWhere(possibilitiesToRemove.Contains);
        }

    }
}
