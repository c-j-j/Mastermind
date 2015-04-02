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
            return SingleStringPermutations(options);
        }

        for (int i = 0; i < options.Length; i++)
        {
            foreach (string subPermutation in Generate(length - 1, options))
            {
                permutations.Add(options[i] + subPermutation);
            }
        }

        return permutations;
    }

    static IEnumerable<string> SingleStringPermutations(string[] options)
    {
        var permutations = new List<string>();

        for (int i = 0; i < options.Length; i++)
        {
            permutations.Add(options[i]);
        }
        return permutations;
    }
}
