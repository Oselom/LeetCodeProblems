namespace LeetBoi.Easy
{
    internal static class Problem83
    {

        //problem 83
        public static ListNode DeleteDuplicates(ListNode head)
        {
            var cHead = head;
            while (cHead != null && cHead.next != null)
            {
                while (cHead.val == cHead.next?.val)
                {
                    cHead.next = cHead.next.next;
                }
                cHead = cHead.next;
            }

            return head;
        }
    }
}