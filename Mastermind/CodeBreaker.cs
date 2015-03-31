using System.Collections.Generic;
using Negamax;

public class CodeBreaker
{

    public void Bar()
    {
        //S = GetPossibibilities();
        //for(int i = 0; i < MAX_TRIES; i++)
        //{
            //g = CodeGuesser.GetGuess(S)
            ////response = CodeMaker.GetResponse(g);
            ////if response is allBlack
                ////print outcome;
            ////S = EliminatePossibilities(S, response)
        //}
    }

    public string FindNextGuess(HashSet<string> possiblities)
    {
        return "1234";
    }

    bool TerminalPredicate(Node<MastermindGame, string> obj)
    {
        throw new System.NotImplementedException();
    }

    int ScoreFunction(Node<MastermindGame, string> arg)
    {
        throw new System.NotImplementedException();
    }

    IEnumerable<Node<MastermindGame, string>> ChildNodeExtractor(Node<MastermindGame, string> arg)
    {
        throw new System.NotImplementedException();
    }

    public string Foo()
    {
        var negamax = new NegamaxCalculator<Node<MastermindGame, string>>(TerminalPredicate, ScoreFunction, ChildNodeExtractor);
        return negamax.Negamax(new Node<MastermindGame, string>(new MastermindGame(), "")).Node.Datum;
    }

}
