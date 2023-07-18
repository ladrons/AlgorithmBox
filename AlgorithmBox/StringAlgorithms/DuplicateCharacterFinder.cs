using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBox.StringAlgorithms
{
    public static class DuplicateCharacterFinder
    {
        public static char[] FindDuplicateChars(string value)
        {
            Dictionary<int, char> sameChars = new Dictionary<int, char>();

            for (int i = 0; i < value.Length; i++)
            {
                for (int j = 0; j < value.Length; j++)
                {
                    if (i != j && value[i] == value[j] && !sameChars.ContainsKey(i))
                    {
                        sameChars.Add(i, value[j]);
                    }
                    else continue;
                }
            }
            char[] duplicateChars = sameChars.Select(x => x.Value).ToArray();

            return duplicateChars;
        }

        public static Dictionary<char, int> CountCharOccurrences(char[] chars)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach (var item in chars)
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item]++;
                }
                else
                {
                    keyValuePairs[item] = 1;
                }
            }
            return keyValuePairs;
        }
    }
}