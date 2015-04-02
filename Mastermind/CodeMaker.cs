using System;
using System.Text;

namespace Mastermind
{
    public interface CodeMaker
    {
        void SetCode(Possibilities possibilities);
        Score GetScore(string guess);
        string SelectedCode
        {
            get;
        }
    }
}
