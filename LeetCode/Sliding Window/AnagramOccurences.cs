using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sliding_Window
{
    public partial class SlidingWindow
    {
        public int search(string pat, string txt)
        {
            int i = 0;
            int j = 0;
            int anagramCount = 0;

            Dictionary<char, int> mapPat = new Dictionary<char, int>();
            foreach (var c in pat)
            {
                if (mapPat.ContainsKey(c))
                {
                    mapPat[c]++;
                }
                else
                {
                    mapPat.Add(c, 1);
                }
            }

            int mapCount = mapPat.Count;
            while (j < txt.Length)
            {

                if (mapPat.ContainsKey(txt[j]))
                {
                    mapPat[txt[j]]--;
                    if (mapPat[txt[j]] == 0)
                    {
                        mapCount--;
                    }

                }

                if ((j - i + 1) != pat.Length)
                {
                    j++;
                }
                else if ((j - i + 1) == pat.Length)
                {
                    if (mapCount == 0)
                    {
                        anagramCount++;
                    }
                    if (mapPat.ContainsKey(txt[i]))
                    {
                        mapPat[txt[i]]++;
                        if (mapPat[txt[i]] == 1)
                        {
                            mapCount++;
                        }
                    }
                    i++;
                    j++;
                }
            }
            return anagramCount;
        }
    }
}
