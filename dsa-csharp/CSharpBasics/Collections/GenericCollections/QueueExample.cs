namespace dsa_csharp.CSharpBasics.Collections.GenericCollections
{
    public class QueueExample
    {
        /*
            WHEN TO USE Queue<T>
            --------------------------------------------
            - FIFO (First-In-First-Out) processing:
              - When order of processing matters.
              - Example: Processing customer requests or task scheduling.

            - Task Scheduling:
              - Background tasks that need to be processed in the order they were added.

            - Breadth-First Search (BFS):
              - Commonly used in graph or tree traversal algorithms.

            - Event Handling:
              - Events need to be processed in the order they occurred.

            LIMITATIONS
            --------------------------------------------
            - Not Thread-Safe:
              - Queue<T> is not thread-safe. For multi-threaded scenarios, use ConcurrentQueue<T>.

            - Resize Overhead:
              - Queue<T> is internally backed by an array.
              - When capacity is exceeded, it resizes, which can cause performance issues.

            PROBLEM-SOLVING SCENARIOS
            --------------------------------------------
            1. Print Job Management:
               - Store and execute print jobs in the order they were submitted.

            2. Task Manager:
               - Store and execute background tasks (e.g., sending emails).

            3. Web Server Request Handling:
               - Store HTTP requests and process them in order.

            4. BFS (Breadth-First Search):
               - Store nodes and explore them level by level.
        */

        static void QueueExampleMain()
        {
            // --------------------------
            // Queue<int> - Basic integer queue
            // --------------------------
            Queue<int> queue = new Queue<int>();

            // Enqueue - Adds elements to the end of the queue (FIFO)
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Peek - Returns the object at the front without removing it
            int front = queue.Peek();
            Console.WriteLine($"Front element: {front}"); // Output: 1

            // Dequeue - Removes and returns the object at the front
            int removed = queue.Dequeue();
            Console.WriteLine($"Removed element: {removed}"); // Output: 1

            // Contains - Checks if an element exists in the queue
            bool contains = queue.Contains(2);
            Console.WriteLine($"Queue contains 2: {contains}"); // Output: true

            // Count - Returns the number of elements in the queue
            int count = queue.Count;
            Console.WriteLine($"Number of elements: {count}"); // Output: 2

            // Iterating through the queue using foreach
            Console.WriteLine("Queue elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item); // Output: 2, 3
            }

            // Clear - Removes all elements from the queue
            queue.Clear();
            Console.WriteLine($"Queue count after clear: {queue.Count}"); // Output: 0

            // --------------------------
            // Queue<string> - Queue with string data
            // --------------------------
            Queue<string> namesQueue = new Queue<string>();
            namesQueue.Enqueue("Pavan");
            namesQueue.Enqueue("Kumar");
            namesQueue.Enqueue("Amit");
            namesQueue.Enqueue("Thakur");

            Console.WriteLine("Names in the queue:");
            foreach (var name in namesQueue)
            {
                Console.WriteLine(name); // Output: Pavan, Kumar, Amit, Thakur
            }

            // --------------------------
            // Queue<List<int>> - Queue of complex objects (List<int>)
            // --------------------------
            Queue<List<int>> intListQueue = new Queue<List<int>>();
            intListQueue.Enqueue(new List<int> { 1, 2, 4, 5, 7 });
            intListQueue.Enqueue(new List<int> { 2, 4, 5, 7 });

            // Accessing list elements from the queue
            var list = intListQueue.Peek(); // First list in the queue
            Console.WriteLine($"First element in the list: {list[0]}"); // Output: 1

            // Removing the first list
            var removedList = intListQueue.Dequeue();
            Console.WriteLine($"Removed list contains: {string.Join(", ", removedList)}"); // Output: 1, 2, 4, 5, 7
        }
    }
}
