using System.Collections.Generic;

namespace Mastermind
{
    public class Possibilities
    {
        readonly string[] possibilities;

        public Possibilities(params string[] possibilities)
        {
            this.possibilities = possibilities;
        }

        public IEnumerable<string> GetPossibilities()
        {
            return possibilities;
        }
    }
}
