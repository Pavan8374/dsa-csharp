using System.Collections;

namespace dsa_csharp.CSharpBasics.Collections.NonGenericCollections
{
    public class SortedListExample
    {
        static void Main()
        {
            SortedList list = new SortedList();

            list.Add(3, "Three");
            list.Add(1, "One");
            list.Add(2, "Two");

            list.Remove(2); // Removes the entry with the specified key.

            string value = (string)list[1]; // Accesses value by key.

            int count = list.Count; // Number of key-value pairs.

            bool containsKey = list.ContainsKey(3); // Returns true if key exists.
            bool containsValue = list.ContainsValue("One"); // Returns true if value exists.

            list.Clear(); // Removes all elements.

            // Iterate through the sorted list
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
