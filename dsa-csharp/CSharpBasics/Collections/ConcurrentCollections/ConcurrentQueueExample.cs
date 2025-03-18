using System.Collections.Concurrent;

namespace dsa_csharp.CSharpBasics.Collections.ConcurrentCollections
{
    /// <summary>
    /// 🔥 ConcurrentQueue<T> is a thread-safe, **FIFO** collection.
    /// 
    /// ✅ When to Use:
    /// - When order matters.
    /// - When multiple threads need to add and remove items concurrently.
    /// - When you need non-blocking, lock-free operations.
    /// 
    /// 🚀 Internal Implementation:
    /// - Uses a **linked-list** internally.
    /// - Lock-free using **Interlocked** operations.
    /// 
    /// ⏳ Time Complexity:
    /// - Enqueue – `O(1)`
    /// - TryDequeue – `O(1)`
    /// </summary>
    public class ConcurrentQueueExample
    {
        static void Main()
        {
            // Create a ConcurrentQueue
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

            // Enqueue – Add items to the queue from multiple threads
            Parallel.For(0, 5, i =>
            {
                queue.Enqueue(i);
                Console.WriteLine($"Item {i} added from Thread {Task.CurrentId}");
            });

            // TryDequeue – Remove and return item from the queue (FIFO)
            if (queue.TryDequeue(out int item))
            {
                Console.WriteLine($"Dequeued item: {item}");
            }

            // TryPeek – Look at the next item without removing it
            if (queue.TryPeek(out int nextItem))
            {
                Console.WriteLine($"Next item: {nextItem}");
            }

            // Count – Get the number of elements
            Console.WriteLine($"Queue contains {queue.Count} items");

            // Enumerating through the queue (in FIFO order)
            Console.WriteLine("Queue elements:");
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
