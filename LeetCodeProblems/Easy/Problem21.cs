namespace LeetBoi.Easy
{
    internal static class Problem21
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public static ListNode CreateListFromArrHelper(int[] arr)
        {
            if (arr.Length == 0) return null;


            var lst = new ListNode(arr[0]);
            var head = lst;
            for (int i = 1; i < arr.Length; i++)
            {
                lst.next = new ListNode(arr[i]);
                lst = lst.next;
            }

            return head;
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null || list2 == null)
                return list1 ?? list2;

            var list3 = new ListNode(0);
            var head = list3;
            while (list1 != null && list2 != null)
            {
                list3.next = new ListNode(0);
                list3 = list3.next;

                if (list1.val <= list2.val)
                {
                    list3.val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    list3.val = list2.val;
                    list2 = list2.next;
                }
            }

            list3.next = list1 ?? list2;

            return head.next;
        }
    }
}