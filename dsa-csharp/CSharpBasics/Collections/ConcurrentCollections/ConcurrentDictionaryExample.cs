using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace dsa_csharp.CSharpBasics.Collections.ConcurrentCollections
{
    /// <summary>
    /// 🔥 ConcurrentDictionary<TKey, TValue> is a thread-safe, key-value pair collection.
    ///
    /// ✅ When to Use:
    /// - When you need fast, thread-safe key-value storage.
    /// - When multiple threads need to update or read the same key-value pairs.
    /// - When you need atomic operations for add, update, and delete.
    ///
    /// 🚀 Internal Implementation:
    /// - Internally uses a **fine-grained locking** strategy.
    /// - Divides the underlying storage into multiple segments to reduce lock contention.
    ///
    /// ⏳ Time Complexity:
    /// - Add – `O(1)` (amortized)
    /// - Remove – `O(1)`
    /// - TryGetValue – `O(1)`
    /// - Indexer – `O(1)`
    /// </summary>
    public class ConcurrentDictionaryExample
    {
        static void ConcurrentDictionaryExampleMain()
        {
            // Create a ConcurrentDictionary
            ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();

            // Add – Add a key-value pair
            if (dictionary.TryAdd(1, "Pavan"))
            {
                Console.WriteLine("Added: 1 => Pavan");
            }

            // Update – Update the value if the key exists
            dictionary.AddOrUpdate(1, "Kumar", (key, oldValue) => "Updated Kumar");

            // Get – Get the value if the key exists
            if (dictionary.TryGetValue(1, out string value))
            {
                Console.WriteLine($"Value for key 1: {value}");
            }

            // Remove – Remove a key-value pair
            if (dictionary.TryRemove(1, out string removedValue))
            {
                Console.WriteLine($"Removed value: {removedValue}");
            }

            // Count – Get the number of elements
            Console.WriteLine($"Dictionary contains {dictionary.Count} items");

            // Enumerate through the dictionary
            dictionary.TryAdd(2, "Amit");
            dictionary.TryAdd(3, "Thakur");

            Console.WriteLine("Dictionary elements:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
