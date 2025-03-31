namespace dsa_csharp.dsa.LinkedLists
{
    public class AddTwoNumbersProblem
    {
        public ListNode Add_Two_Numbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode current = dummyHead;
            int carry = 0;

            //ex: l1: 2 -> 4 -> 5,  l2: 5 -> 0 -> 3 , add: 748, ex o/p: 847

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
                    //3. 
                    sum += l1.val;  


                    //1. l1 = 4 
                    //2. l1 = 5
                    //3. l1 = null
                    l1 = l1.next;
                }

                if(l2 != null)
                {
                    //1. sum = 2 + 5 = 7
                    //2. sum = 5 + 4 = 9
                    //3. sum = 
                    sum += l2.val;

                    //1. l2 = 0
                    //2. l2 = 3
                    //3. l2 = null
                    l2 = l2.next;
                }

                //1.carry = 7/10 = 0
                //2. carry = 
                //3.
                carry = sum / 10;

                //1.carry.next = Listnode => 7, null
                //2.
                //3.
                current.next = new ListNode(sum % 10);

                //1.current = Listnode => 7, null
                //2.
                //3.
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
