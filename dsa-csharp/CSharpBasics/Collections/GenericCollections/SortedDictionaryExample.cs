using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System;

namespace dsa_csharp.CSharpBasics.Collections.GenericCollections
{
    /// <summary>
    /// SortedDictionary<TKey, TValue> is a collection of **key-value pairs** sorted by key.
    /// 
    /// When to Use:
    /// - When you need to store key-value pairs.
    /// - When you need automatic sorting based on keys.
    /// - When you require fast lookup, insertion, and deletion by key.
    /// - When the keys need to be **unique**.
    /// 
    /// Internal Implementation:
    /// - Internally uses a **binary search tree** (Red-Black Tree).
    /// - Maintains elements in a sorted order based on the key.
    /// - Handles duplicate keys by overwriting the value.
    /// 
    ///  Notes:
    /// - Keys must be unique.
    /// - If a custom object is used as a key, it should implement **IComparable** or you need to pass a custom **IComparer**.
    /// 
    /// Time Complexity:
    /// - Insertion, deletion, and search – `O(log n)` due to the Red-Black Tree structure.
    /// - Iteration – `O(n)` (in ascending order).
    /// </summary>
    /// 
    /// 
    /// Real-World Use Cases: 
    /// - Maintaining a leaderboard or ranking system.
    /// - Caching values in a sorted order.
    /// - Event scheduling where keys are timestamps or priorities.
    /// - Storing data that must be accessed in sorted order.
    ///











    public class SortedDictionaryExample
    {
        static void SortedDictionaryExampleMain()
        {
            // Create a SortedDictionary
            SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();

            // Add elements (Keys will be stored in ascending order)
            sortedDict.Add(3, "Pavan");
            sortedDict.Add(1, "Kumar");
            sortedDict.Add(2, "Thakur");

            // Throws an exception if key already exists
            // sortedDict.Add(2, "Duplicate"); // Error

            Console.WriteLine("SortedDictionary elements:");
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Accessing a value by key
            string value = sortedDict[2]; // "Thakur"

            // TryGetValue – Safe way to get value without exception
            if (sortedDict.TryGetValue(1, out string result))
            {
                Console.WriteLine($"\nValue for key 1: {result}");
            }

            // Updating value for an existing key
            sortedDict[2] = "Updated Thakur"; // Replaces existing value

            // Removing an element by key
            sortedDict.Remove(1);

            // Count – Get the number of elements
            int count = sortedDict.Count;

            // ContainsKey – Check if a key exists
            bool containsKey = sortedDict.ContainsKey(2); // true

            // ContainsValue – Check if a value exists
            bool containsValue = sortedDict.ContainsValue("Pavan"); // true

            // Keys and Values collection
            Console.WriteLine("\nKeys:");
            foreach (var key in sortedDict.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nValues:");
            foreach (var val in sortedDict.Values)
            {
                Console.WriteLine(val);
            }

            // Clear – Remove all elements
            sortedDict.Clear();

            // Custom Object as Key Example:
            // To use a custom object as a key, you need to implement IComparable or pass a custom comparer.
            SortedDictionary<Person, string> personDict = new SortedDictionary<Person, string>(new PersonComparer())
            {
                { new Person { Name = "Pavan", Age = 24 }, "Developer" },
                { new Person { Name = "Kumar", Age = 25 }, "Tester" }
            };

            Console.WriteLine("\nCustom Object SortedDictionary:");
            foreach (var kvp in personDict)
            {
                Console.WriteLine($"Key: {kvp.Key.Name}, {kvp.Key.Age}, Value: {kvp.Value}");
            }

            // TryAdd – Adds a key-value pair only if the key does not already exist
            bool added = sortedDict.TryAdd(4, "New Value"); // true
            bool notAdded = sortedDict.TryAdd(4, "Duplicate"); // false
        }

        /// <summary>
        /// Custom object example with IComparable for sorting by age
        /// </summary>
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        /// <summary>
        /// Custom comparer to sort Person objects by Age
        /// </summary>
        public class PersonComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                if (x == null || y == null) return 0;
                return x.Age.CompareTo(y.Age);
            }
        }
    }
}
