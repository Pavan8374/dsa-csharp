using System.Collections;

namespace dsa_csharp.CSharpBasics.Collections.NonGenericCollections
{
    public class HashTableExample
    {
        static void HashTableExampleMain()
        {
            Hashtable table = new Hashtable();

            table.Add(1, "One"); // Adds a key-value pair.
            table.Add(2, "Two");
            table.Add(3, "Three");

            table.Remove(2); // Removes the entry with the specified key.

            bool containsKey = table.ContainsKey(1); // Returns true if key exists.
            bool containsValue = table.ContainsValue("Three"); // Returns true if value exists.

            int count = table.Count; // Returns the number of key-value pairs.

            table.Clear(); // Removes all entries from the Hashtable.

            // Iterate through the table
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
