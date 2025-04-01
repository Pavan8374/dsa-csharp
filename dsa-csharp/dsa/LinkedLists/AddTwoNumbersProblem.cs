namespace dsa_csharp.dsa.LinkedLists
{
    public class AddTwoNumbersProblem
    {
        // 2: https://leetcode.com/problems/add-two-numbers
        // You are given two non-empty linked lists representing two non-negative integers.
        // The digits are stored in reverse order, and each of their nodes contains a single digit.
        // Add the two numbers and return the sum as a linked list.

        public AddTwoNumbersProblem()
        {
            AddTwoNumbersProblem.ListNode l1 = new AddTwoNumbersProblem.ListNode(5);
            l1.next = new AddTwoNumbersProblem.ListNode(4);
            l1.next.next = new AddTwoNumbersProblem.ListNode(2);

            AddTwoNumbersProblem.ListNode l2 = new AddTwoNumbersProblem.ListNode(3);
            l2.next = new AddTwoNumbersProblem.ListNode(0);
            l2.next.next = new AddTwoNumbersProblem.ListNode(5);
            var node = Add_Two_Numbers(l1, l2);
            Console.Write("Result: ");
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }

        }

        public static ListNode Add_Two_Numbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode current = dummyHead;
            int carry = 0;

            // Example: l1: 2 -> 4 -> 5,  l2: 5 -> 0 -> 3  
            // Expected sum: 245 + 503 = 748
            // Output Linked List: 8 -> 4 -> 7

            //1. l1 or l2 not null and carry is 0
            //2. l1 or l2 not null and carry is 0
            //3. l1 or l2 not null and carry is 0
            //4. l1 or l2 are null and carry is 0
            while (l1 != null || l2 != null || carry > 0)
            {
                //1. sum = 0
                //2. sum = 0
                //3. sum = 0
                int sum = carry;  

                if(l1 != null)
                {
                    //1. sum = 0 (carry) + 2 = 2
                    //2. sum = 0 +  4 = 4
                    //3. sum = 0 + 5 = 5
                    sum += l1.val;  


                    //1. l1 = 4 
                    //2. l1 = 5
                    //3. l1 = null
                    l1 = l1.next;
                }

                if(l2 != null)
                {
                    //1. sum = 2 + 5 = 7
                    //2. sum = 4 + 0 = 4
                    //3. sum = 5 + 3 = 8
                    sum += l2.val;

                    //1. l2 = 0
                    //2. l2 = 3
                    //3. l2 = null
                    l2 = l2.next;
                }

                //1.carry = 7/10 = 0
                //2.carry = 5/10 = 0
                //3.cary = 8/10 = 0
                carry = sum / 10;

                //1.carry.next = Listnode => 7, null
                //2.carry.next = Listnode => 4, null
                //3.carry.next = Listnode => 8, null
                current.next = new ListNode(sum % 10);

                //1.current = Listnode => 7, null
                //2.current = Listnode => 4, null
                //3.current = Listnode => 8, null
                current = current.next;

            }
            return dummyHead.next;

        }




        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
