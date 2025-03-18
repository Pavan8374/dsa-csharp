using System.Collections;

namespace dsa_csharp.CSharpBasics.Collections.NonGenericCollections
{
    class StackExample
    {
        static void Main()
        {
            Stack stack = new Stack();

            stack.Push(1); // Pushes an object onto the stack.
            stack.Push(2);
            stack.Push(3);

            var topElement = stack.Peek(); // Returns the object at the top without removing it.

            stack.Pop(); // Removes and returns the top object.

            bool contains = stack.Contains(2); // Returns true if the object exists.

            int count = stack.Count; // Number of elements in the stack.

            stack.Clear(); // Removes all elements from the stack.

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
