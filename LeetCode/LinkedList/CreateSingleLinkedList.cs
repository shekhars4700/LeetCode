using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class Node {
        public int value;
        public Node next;
        public Node(int value)
        {
            this.value = value;
        }
        public Node(int value, Node next)
        {
            this.value = value;
            this.next = next;
        }
    }
    public static class CreateSingleLinkedList
    {
        public static Node Create(List<int> intList) {
            Node head = null;
            Node mover = null;

            foreach (int i in intList)
            {
                if (head == null) { 
                    head = new Node(i);
                    mover = head;
                }
                else
                {
                    Node temp = new Node(i);
                    mover.next = temp;
                }
            }
            return head;
        }
        public static void Print(List<int> intList)
        {
            Node head = Create(intList);
            Node mover = head;
            while (mover != null)
            {
                Console.WriteLine(mover.value);
                mover = mover.next;
            }
        }
        public static bool Find(List<int> intList, int k)
        {
            Node head = Create(intList);
            Node mover = head;
            while (mover != null)
            {
                if (mover.value == k)
                {
                    return true;
                }
                mover = mover.next;
            }
            return false;
        }

        public static int Count(List<int> intList, int k)
        {
            Node head = Create(intList);
            Node mover = head;
            int count = 0;
            while (mover != null)
            {
                count+=1;
                mover = mover.next;
            }
            return count;
        }
    }
}
