using System.Text;
using NeedleFinder.Utils;

namespace NeedleFinder
{
    public static class Finder
    {
        public static string GetMatchResult(string text, string subtext, bool matchCase)
        {
            StringBuilder matchResult = new StringBuilder();

            int[] matches = text.Match(subtext, matchCase);

            if (matches.Length == 0)
            {
                matchResult.Append("no matches");
            }
            else
            {   
                for (int i = 0; i < matches.Length; i++)
                {
                    matchResult.AppendFormat("{0:d}", matches[i]);
                    if (i < (matches.Length - 1))
                    {
                        matchResult.Append(", ");
                    }
                }
            }

            return matchResult.ToString();
        }
    }
}
