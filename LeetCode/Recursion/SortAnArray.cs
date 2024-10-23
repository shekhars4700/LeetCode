using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class Recursion2
    {

        public static void insertionSort() {
            var lst = SortAnArray(new List<int> { 1, 0, 5, 2 });
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> SortAnArray(List<int> vs) {
            if (vs.Count == 1) {
                return vs;
            }

            int lastEle = vs.Last();
            vs.RemoveAt(vs.Count - 1);
            SortAnArray(vs);

            insert(vs,lastEle);
            return vs;
        }


        public static void insert(List<int> vs, int lastEle)
        {
            if (vs.Count == 0 || vs.Last() < lastEle)
            {
                vs.Add(lastEle);
                return;
            }
            var element = vs.Last();
            vs.RemoveAt(vs.Count - 1);
            insert(vs, lastEle);
            
            vs.Add(element);
        }
    }
}
