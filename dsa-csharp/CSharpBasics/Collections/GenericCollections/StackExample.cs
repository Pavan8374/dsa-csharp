namespace dsa_csharp.CSharpBasics.Collections.GenericCollections
{
    public class StackExample
    {
        /*
            WHEN TO USE Stack<T>
            --------------------------------------------
            - LIFO (Last-In-First-Out) processing:
              - When the last inserted element should be processed first.
              - Example: Undo functionality in text editors or code editors.

            - Depth-First Search (DFS):
              - Commonly used for graph or tree traversal algorithms.

            - Backtracking:
              - Used for solving problems like Sudoku or maze pathfinding.

            - Function Call Stack:
              - Used internally to store function calls and execution flow.

            LIMITATIONS
            --------------------------------------------
            - Not Thread-Safe:
              - Stack<T> is not thread-safe. Use ConcurrentStack<T> for multi-threaded scenarios.

            - Performance Hit on Large Data:
              - Stack resizes internally when capacity is exceeded, causing performance degradation.

            PROBLEM-SOLVING SCENARIOS
            --------------------------------------------
            1. Undo/Redo:
               - Store user actions and revert them using LIFO order.

            2. Backtracking:
               - Used to explore paths and return when a dead-end is reached.

            3. Expression Evaluation:
               - Evaluate mathematical expressions using operator precedence.

            4. DFS (Depth-First Search):
               - Used to explore all possible paths in a graph or tree.
        */

        static void StackExampleMain()
        {
            // --------------------------
            // Stack<int> - Basic integer stack
            // --------------------------
            Stack<int> stack = new Stack<int>();

            // Push - Adds elements to the top of the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Peek - Returns the element at the top without removing it
            int top = stack.Peek();
            Console.WriteLine($"Top element: {top}"); // Output: 3

            // Pop - Removes and returns the element at the top
            int removed = stack.Pop();
            Console.WriteLine($"Removed element: {removed}"); // Output: 3

            // Contains - Checks if an element exists in the stack
            bool contains = stack.Contains(2);
            Console.WriteLine($"Stack contains 2: {contains}"); // Output: true

            // Count - Returns the number of elements in the stack
            int count = stack.Count;
            Console.WriteLine($"Number of elements: {count}"); // Output: 2

            // Iterating through the stack using foreach
            Console.WriteLine("Stack elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item); // Output: 2, 1 (in LIFO order)
            }

            // Clear - Removes all elements from the stack
            stack.Clear();
            Console.WriteLine($"Stack count after clear: {stack.Count}"); // Output: 0

            // --------------------------
            // Stack<string> - Stack with string data
            // --------------------------
            Stack<string> undoStack = new Stack<string>();
            undoStack.Push("Open File");
            undoStack.Push("Edit Line");
            undoStack.Push("Save File");

            // Simulating undo operation
            Console.WriteLine($"Undo action: {undoStack.Pop()}"); // Output: Save File
            Console.WriteLine($"Next action to undo: {undoStack.Peek()}"); // Output: Edit Line

            // --------------------------
            // Stack<List<int>> - Stack of complex objects (List<int>)
            // --------------------------
            Stack<List<int>> listStack = new Stack<List<int>>();
            listStack.Push(new List<int> { 1, 2, 3 });
            listStack.Push(new List<int> { 4, 5, 6 });

            // Accessing list elements from the stack
            var list = listStack.Peek(); // Top list in the stack
            Console.WriteLine($"First element in the top list: {list[0]}"); // Output: 4

            // Removing the top list
            var removedList = listStack.Pop();
            Console.WriteLine($"Removed list contains: {string.Join(", ", removedList)}"); // Output: 4, 5, 6
        }
    }
}
