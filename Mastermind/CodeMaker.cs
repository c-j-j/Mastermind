using System;
using System.Text;

namespace Mastermind
{
    public interface CodeMaker
    {
        void SelectCode(Possibilities possibilities);

        string SelectedCode
        {
            get;
        }
    }
}
