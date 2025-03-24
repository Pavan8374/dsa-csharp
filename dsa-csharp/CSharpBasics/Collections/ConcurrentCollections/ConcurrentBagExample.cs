namespace dsa_csharp.CSharpBasics.Collections.ConcurrentCollections
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    namespace dsa_csharp.CSharpBasics.Collections.ConcurrentCollections
    {
        /// <summary>
        /// ConcurrentBag<T> is a thread-safe, unordered collection of objects.
        /// 
        /// When to Use:
        /// - When you need fast insertion and removal from multiple threads.
        /// - When the order of elements **doesn't matter**.
        /// - When high performance is needed for unordered data storage.
        /// 
        /// Internal Implementation:
        /// - Uses **thread-local storage**.
        /// - Reduces lock contention using local thread caches.
        /// - Uses lock-free techniques for thread safety.
        /// 
        /// Time Complexity:
        /// - Add – `O(1)` (amortized)
        /// - TryTake – `O(1)` (amortized)
        /// - Count – `O(n)`
        /// </summary>
        public class ConcurrentBagExample
        {
            static void ConcurrentBagExampleMain()
            {
                // ✅ Create a ConcurrentBag
                ConcurrentBag<int> bag = new ConcurrentBag<int>();

                // 🔹 Add items to the bag from multiple threads
                Parallel.For(0, 5, i =>
                {
                    bag.Add(i);
                    Console.WriteLine($"Item {i} added from Thread {Task.CurrentId}");
                });

                // 🔹 TryTake – Remove item from the bag
                if (bag.TryTake(out int item))
                {
                    Console.WriteLine($"Removed item: {item}");
                }

                // 🔹 TryPeek – Look at the next item without removing it
                if (bag.TryPeek(out int peekItem))
                {
                    Console.WriteLine($"Next item: {peekItem}");
                }

                // 🔹 Count – Get the number of elements
                Console.WriteLine($"Bag contains {bag.Count} items");

                // 🔹 Enumerating through the bag (unordered)
                Console.WriteLine("Bag elements:");
                foreach (var i in bag)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
