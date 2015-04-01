using System;
using System.Collections.Generic;
using System.Linq;

public class Permutation
{

    public static IEnumerable<string> Generate(int length, params string[] options)
    {
        var permutations = new List<string>();

        if (length == 1)
        {
            for (int i = 0; i < options.Length; i++)
            {
                permutations.Add(CreatePermutation(length, options[i]));
            }
        }
        else
        {
            for (int i = 0; i < options.Length; i++)
            {
                foreach (string item in Generate(length - 1, options))
                {
                    permutations.Add(options[i] + item);
                }
            }
        }


        return permutations;
    }

    static string CreatePermutation(int length, string element)
    {
        string permutation = "";
        for (int i = 0; i < length; i++)
        {
            permutation += element;
        }
        return permutation;
    }
}
