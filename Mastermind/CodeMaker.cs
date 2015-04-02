using System;
using System.Text;

namespace Mastermind
{
    public interface CodeMaker
    {
        Score GetScore(string guess);

        string SelectedCode
        {
            get;
        }
    }
}
