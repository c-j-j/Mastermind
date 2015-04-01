using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using NUnit.Framework.SyntaxHelpers;

namespace Mastermind.Test
{
    [TestFixture]
    public class CombinationTest
    {
        [Test]
        public void GeneratesSinglePermutation()
        {
            AssertAreEqual(Set("a"), Permutation.Generate(1, "a"));
        }

        [Test]
        public void GeneratesSinglePermutationWithLengthThree()
        {
            AssertAreEqual(Set("aaa"), Permutation.Generate(3, "a"));
        }

        [Test]
        public void GeneratesTwoPermutationsWithThreeOptions()
        {
            AssertAreEqual(Set("a", "b", "c"), Permutation.Generate(1, "a", "b", "c"));
        }

        [Test]
        public void GeneratesPermutationWithTwoOptionsWithLengthTwo()
        {
            AssertAreEqual(Set("aa", "ab", "ba", "bb"), Permutation.Generate(2, "a", "b"));
        }

        [Test]
        public void GeneratesPermutationWithTwoOptionsWithLengthThree()
        {
            AssertAreEqual(Set("aa", "ac", "ca", "cc"), Permutation.Generate(2, "a", "c"));
        }

        [Test]
        public void GeneratesPermutationWithTwoDifferentOptionsWithLengthThree()
        {
            AssertAreEqual(Set("bb", "bc", "cb", "cc"), Permutation.Generate(2, "b", "c"));
        }

        [Test]
        public void GeneratesPermutationWithTwoOptionOfLengthThree()
        {
            AssertAreEqual(Set("aaa", "aab", "aba", "abb", "bab", "baa", "bba", "bbb"), Permutation.Generate(3, "a", "b"));
        }

        [Test]
        public void GeneratesAllPossibilities()
        {
            var permutations = Permutation.Generate(4, "1", "2", "3", "4", "5", "6");
            Assert.AreEqual(1296, permutations.Count());
        }
        static IEnumerable<string> Set(params string[] elements)
        {
            return new HashSet<string>(elements);
        }

        void AssertAreEqual(IEnumerable<string> expected, IEnumerable<string> actual)
        {
            CollectionAssert.AreEquivalent(expected, actual, "expected: " + string.Join(",", expected));
        }
    }
}
