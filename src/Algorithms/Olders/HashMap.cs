using System.Collections.Generic;

namespace Algorithms.Olders
{
    public static class HashMap
    {
        //Time: O(n)
        public static Dictionary<string,int> FindUniqueWordsAndTheirCount(string[] words)
        {
            var hashMap = new Dictionary<string,int>();

            for (var i = 0; i < words.Length; i++)
            {
                if (hashMap.ContainsKey(words[i]))
                    hashMap[words[i]]++;
                else
                    hashMap.Add(words[i], 1);
            }

            return hashMap;
        }
    }
}