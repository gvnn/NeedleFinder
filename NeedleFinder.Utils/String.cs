using NeedleFinder.Utils.Collections;

namespace NeedleFinder.Utils
{
    public static class String
    {
        /// <summary>
        /// Extension method that implements the Knuth–Morris–Pratt algorithm.
        /// </summary>
        /// <param name='text'>
        /// Text to search through.
        /// </param>
        /// <param name='subtext'>
        /// Pattern trying to match.
        /// </param>
        /// <returns>
        /// Array with all the matche
        /// </returns>
        public static int[] Match(this string text, string subtext, bool caseInsensitive = false)
        {
            if (subtext.Length == 0 || text.Length == 0)
            {
                return new int[] { };
            }

            LinkedList<int> occurences = new LinkedList<int>();

            int m = subtext.Length; // the beginning of the current match in text
            int q = 0; // the position of the current character in subtext

            // build partial match table
            int[] kpmTable = computeKmpTable(subtext);

            // looping on eveyr char
            for (int i = 1; i <= text.Length; i++)
            {
                while (q > 0 && !IsMatch(subtext[q], text[i - 1], caseInsensitive))
                {
                    q = kpmTable[q - 1];
                }
                if (IsMatch(subtext[q], text[i - 1], caseInsensitive))
                {
                    q++;
                }
                if (q == m)
                {
                    // we have a match
                    q = kpmTable[q - 1];
                    occurences.Add(new LinkedListNode<int>(i + 1 - m));
                }
            }

            return occurences.ToArray();
        }

        /// <summary>
        /// Generate the failure table using the substring and the length.
        /// </summary>
        /// <returns>
        /// Partial match table.
        /// </returns>
        /// <param name='subtext'>
        /// Pattern trying to match.
        /// </param>
        /// <returns>
        /// Int array with fallback positions
        /// </returns>
        private static int[] computeKmpTable(string subtext)
        {
            int[] table = new int[subtext.Length];

            int i = 1; // the current position
            int j = 0; // prev position

            if (table.Length > 0)
            {
                table[0] = 0;
            }

            while (i < subtext.Length)
            {
                if (subtext[j] == subtext[i])
                {
                    // first case: the substring continues
                    table[i] = j + 1;
                    i++;
                    j++;
                }
                else if (j > 0)
                {
                    // second case: it doesn't, but we can fall back
                    j = table[j - 1];
                }
                else
                {
                    // third case: we have run out of candidates.
                    table[i] = 0;
                    i++;
                }
            }

            return table;
        }

        private static bool IsMatch(char a, char b, bool caseInsensitive)
        {
            if (caseInsensitive)
            {
                char char1, char2;
                char1 = (a >= 'A' && a <= 'Z') ? (char)((int)a + 32) : a;
                char2 = (b >= 'A' && b <= 'Z') ? (char)((int)b + 32) : b;
                return (char1 == char2);
            }
            else
            {
                return (a == b);
            }
        }
    }
}