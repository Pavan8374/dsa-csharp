using System.Collections.Concurrent;

namespace dsa_csharp.CSharpBasics.Collections.ConcurrentCollections
{
    /// <summary>
    /// BlockingCollection<T> is a thread-safe, bounded (or unbounded) collection.
    /// 
    /// When to Use:
    /// - When you need a producer-consumer queue.
    /// - When you want to limit the number of items in the collection.
    ///
    /// Internal Implementation:
    /// - Uses `IProducerConsumerCollection<T>` internally.
    /// - Supports blocking and non-blocking behavior.
    ///
    /// Time Complexity:
    /// - Add – `O(1)`
    /// - Take – `O(1)`
    /// </summary>
    public class BlockingCollectionExample
    {
        static void Main()
        {
            BlockingCollection<int> collection = new BlockingCollection<int>(5); // Bounded size

            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    collection.Add(i);
                    Console.WriteLine($"Added: {i}");
                }
                collection.CompleteAdding();
            });

            Task.Run(() =>
            {
                foreach (var item in collection.GetConsumingEnumerable())
                {
                    Console.WriteLine($"Consumed: {item}");
                }
            }).Wait();
        }
    }
}
