using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace dsa_csharp.CSharpBasics.Collections.ConcurrentCollections
{
    /// <summary>
    /// ConcurrentStack<T> is a thread-safe, **LIFO** (Last-In-First-Out) collection.
    /// 
    /// When to Use:
    /// - When order matters in a **Last-In-First-Out** (LIFO) manner.
    /// - When you need non-blocking operations for fast push and pop.
    /// - When multiple threads need to modify the stack simultaneously.
    ///
    /// Internal Implementation:
    /// - Uses a **linked list** internally.
    /// - Lock-free using **Interlocked** operations.
    ///
    /// Time Complexity:
    /// - Push – `O(1)`
    /// - TryPop – `O(1)`
    /// - TryPeek – `O(1)`
    /// </summary>
    public class ConcurrentStackExample
    {
        static void Main()
        {
            // Create a ConcurrentStack
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            // Push – Add items to the stack from multiple threads
            Parallel.For(0, 5, i =>
            {
                stack.Push(i);
                Console.WriteLine($"Item {i} pushed from Thread {Task.CurrentId}");
            });

            // TryPop – Remove and return the top item (LIFO)
            if (stack.TryPop(out int item))
            {
                Console.WriteLine($"Popped item: {item}");
            }

            // TryPeek – Look at the top item without removing it
            if (stack.TryPeek(out int nextItem))
            {
                Console.WriteLine($"Next item: {nextItem}");
            }

            // Count – Get the number of elements
            Console.WriteLine($"Stack contains {stack.Count} items");

            // Enumerating through the stack (in LIFO order)
            Console.WriteLine("Stack elements:");
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
