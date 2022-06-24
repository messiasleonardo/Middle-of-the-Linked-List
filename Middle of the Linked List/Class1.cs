namespace Middle_of_the_Linked_List
{
    public class Solution
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
        public int[] MiddleNodeArrayList(int[] head)
        {
            int countMiddleArray = head.Length / 2;
            int countLeft = 0;
            int countRight = 0;

            for (int i = 0; i < countMiddleArray; i++)
            {
                countLeft++;
            }
            for (int i = countMiddleArray+1; i < head.Length; i++)
            {
                countRight++;
            }

            int[] result = new int[head.Length-countMiddleArray];
            if (countRight == countLeft)
            {
                for (int i = countMiddleArray, j = 0; i < head.Length; i++, j++)
                {
                    result[j] = head[i];
                }
                return result;
            }
            else
            {
                countLeft = 0;
                countRight = 0;

                for (int i = 0; i < countMiddleArray-1; i++)
                {
                    countLeft++;
                }
                for (int i = countMiddleArray + 1; i < head.Length; i++)
                {
                    countRight++;
                }

                if (countRight == countLeft)
                {
                    for (int i = countMiddleArray, j = 0; i < head.Length; i++, j++)
                    {
                        result[j] = head[i];
                    }
                    return result;
                }
            }

            return result;
        }

        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head, fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            if (fast.next != null)
                return slow.next;
            return slow;

        }

    }
}