namespace dsa_csharp.CSharpBasics.Problems
{

    public class ReverseALinkedList
    {
        // Linked List: linked list is a linear ds that stores non-contaguous location. 
        // The elements are Linked with each other using pointers. in other wards, it contains nodes have data field,
        // and reference to the next node in the list. 

        // In C#, LinkedList is the generic type of collection that is defined in the System.Collections.Generic namespace. 
        public static void Reverse_LinkedList(LinkedList<int> ll)
        {

            if (ll == null || !ll.Any())
                throw new ArgumentException("Linked list is empty!");

            var rl = ll.Reverse();
            foreach(int i in rl)
            {
                Console.WriteLine(i);
            }
        }

    }
    
}
