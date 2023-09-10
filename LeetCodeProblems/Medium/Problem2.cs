namespace LeetBoi.Medium
{
    internal class Problem2
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var l3 = new ListNode();
            var l3header = l3;
            var leftover = 0;
            while (true)
            {
                l3.val = l1.val + l2.val + leftover;
                if (l3.val > 9)
                {
                    l3.val %= 10;
                    leftover = 1;
                }
                else
                {
                    leftover = 0;
                }


                l1 = l1.next;
                l2 = l2.next;
                if (l1 == null || l2 == null)
                { break; }
                else
                {
                    l3.next = new ListNode();
                    l3 = l3.next;
                }
            }

            var listWithElementsLeft = l1 ?? l2;

            if (listWithElementsLeft == null)
            {
                if (leftover == 1)
                {
                    l3.next = new ListNode(1);
                }
                return l3header;
            }
            else
            {
                l3.next = new ListNode();
                l3 = l3.next;
            }

            while (true)
            {
                l3.val = listWithElementsLeft.val + leftover;
                if (l3.val > 9)
                {
                    l3.val = 0;
                    leftover = 1;
                }
                else
                {
                    leftover = 0;
                }


                listWithElementsLeft = listWithElementsLeft.next;
                if (listWithElementsLeft != null)
                {
                    l3.next = new ListNode();
                    l3 = l3.next;
                }
                else
                {
                    break;
                }
            }

            if (leftover == 1)
            {
                l3.next = new ListNode(1);
            }

            return l3header;
        }
    }
}
