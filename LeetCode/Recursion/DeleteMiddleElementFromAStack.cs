﻿using LeetCode.LinkedList;
using System.Collections.Generic;

namespace LeetCode
{
    class DeleteMiddleElementFromAStack
    {
        public static ListNode DeletionOfHead(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode node = head.next;
            head = null;
            return node;
        }
        public static ListNode DeletionOfTail(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode prev = head;
            ListNode node = head.next;
            while (node.next != null)
            {
                prev = node;
                node = node.next;
            }
            prev.next = null;
            return head;
        }
        
        public static ListNode DeletionAtK(ListNode head, int k)
        {
            if (k == 1)
            {
                return head != null ? head.next : head;
            }
            ListNode prev = head;
            ListNode node = head.next;
            while (k != 1 && node != null)
            {
                prev = node;
                node = node.next;
                k -= 1;
            }
            if (k == 0)
            {
                prev.next = node.next;
            }
            return head;
        }

        public static ListNode DeletionOfK(ListNode head, int k)
        {
            if (k == 1)
            {
                return head != null ? head.next : head;
            }
            ListNode prev = head;
            ListNode node = head.next;
            while (node != null && node.val == k)
            {
                prev = node;
                node = node.next;
            }
            if (node.next != null)
            {
                prev.next = node.next;
            }
            else {
                prev.next = null;
            }
            return head;
        }
    }
}
