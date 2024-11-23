using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public static class Add1ToLL
    {
        public static void Main(int[] arr) {
            ListNode ll = CreateSingleLinkedList.Create(arr.ToList());
            ListNode dummy = new ListNode();
            dummy.next = ll;
            var carry = Solve(dummy);
           
        }

        public static int Solve(ListNode ll)
        {

            if (ll == null) {
                return 1;
            }

            var N = ll.next;
            int carry = Solve(N);
            ll.val = (ll.val + carry)%10;
            carry = (ll.val + carry) / 10;
            return carry;
        }
    }
}
