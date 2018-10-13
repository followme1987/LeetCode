using System;
using System.Collections.Generic;

namespace ShortestWordDistance
{
    public class ShortestWordDistance
    {
        public int ShortestDistance(string[] words, string word1, string word2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            for (var i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(word1)) list1.Add(i);
                if (words[i].Equals(word2)) list2.Add(i);
            }

            var result = new List<int>();
            foreach (var l1 in list1)
            foreach (var l2 in list2)
                result.Add(Math.Abs(l1 - l2));

            result.Sort();
            return result[0];
        }
    }
}