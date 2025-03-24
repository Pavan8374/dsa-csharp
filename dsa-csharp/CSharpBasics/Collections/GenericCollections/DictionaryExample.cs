namespace dsa_csharp.CSharpBasics.Collections.GenericCollections
{
    public class DictionaryExample
    {
        /*
            WHEN TO USE Dictionary<TKey, TValue>
            --------------------------------------------
            - Fast Lookup:
              - When you need fast lookup of values by keys (O(1) average time complexity).
              - Example: Caching, indexing, or mapping data based on keys.

            - Unique Keys:
              - When you need to store unique key-value pairs.
              - Example: Storing user information by unique user ID.

            - Key-Based Retrieval:
              - When you need to access values based on keys rather than index.

            LIMITATIONS
            --------------------------------------------
            - No Duplicate Keys:
              - If you try to add a duplicate key, it will throw an exception.

            - Unordered:
              - The order of elements is not maintained.

            - Not Thread-Safe:
              - Dictionary<TKey, TValue> is not thread-safe. Use `ConcurrentDictionary<TKey, TValue>` for multi-threaded scenarios.

            PROBLEM-SOLVING SCENARIOS
            --------------------------------------------
            1. Fast Lookup:
               - Ideal for storing and retrieving data by unique keys quickly.

            2. Mapping:
               - Storing a mapping of one data type to another.

            3. Grouping:
               - Use it to group values under a unique key.

            4. Counting Frequency:
               - Count the frequency of elements or characters.

            5. Caching:
               - Use it to store frequently accessed data.
        */

        static void DictionaryExampleMain()
        {
            // --------------------------
            // Dictionary<int, string> - Basic Integer to String Mapping
            // --------------------------
            Dictionary<int, string> students = new Dictionary<int, string>();

            // Add - Adds a key-value pair
            students.Add(1, "Pavan");
            students.Add(2, "Kumar");
            students.Add(3, "Amit");

            // Accessing values by key
            Console.WriteLine($"Student with ID 1: {students[1]}"); // Output: Pavan

            // TryGetValue - Returns true if the key exists; avoids exception
            if (students.TryGetValue(2, out var name))
            {
                Console.WriteLine($"Student with ID 2: {name}");
            }

            // Count - Returns the number of key-value pairs
            Console.WriteLine($"Total students: {students.Count}"); // Output: 3

            // ContainsKey - Checks if the dictionary contains a key
            bool hasStudentWithId3 = students.ContainsKey(3);
            Console.WriteLine($"Contains ID 3: {hasStudentWithId3}"); // Output: True

            // ContainsValue - Checks if the dictionary contains a value
            bool hasStudentNamedAmit = students.ContainsValue("Amit");
            Console.WriteLine($"Contains student named Amit: {hasStudentNamedAmit}"); // Output: True

            // Remove - Removes a key-value pair by key
            students.Remove(2);

            // Keys - Returns a collection of keys
            Console.WriteLine("All student IDs:");
            foreach (var id in students.Keys)
            {
                Console.WriteLine(id);
            }

            // Values - Returns a collection of values
            Console.WriteLine("All student names:");
            foreach (var studentName in students.Values)
            {
                Console.WriteLine(studentName);
            }

            // --------------------------
            // Dictionary<string, int> - Counting Frequency of Elements
            // --------------------------
            string input = "banana";
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            Console.WriteLine("Character frequency:");
            foreach (var pair in frequency)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            // Output:
            // b: 1
            // a: 3
            // n: 2

            // --------------------------
            // Dictionary<string, List<int>> - Grouping Data (Multi-Valued Dictionary)
            // --------------------------
            Dictionary<string, List<int>> studentScores = new Dictionary<string, List<int>>
            {
                { "Pavan", new List<int> { 85, 90, 78 } },
                { "Kumar", new List<int> { 88, 92 } }
            };

            // Adding new score to an existing student
            studentScores["Pavan"].Add(95);

            Console.WriteLine("Student scores:");
            foreach (var kvp in studentScores)
            {
                Console.Write($"{kvp.Key}: ");
                foreach (var score in kvp.Value)
                {
                    Console.Write(score + " ");
                }
                Console.WriteLine();
            }
            // Output:
            // Pavan: 85 90 78 95
            // Kumar: 88 92

            // --------------------------
            // Dictionary<int, object> - Mixed Types
            // --------------------------
            Dictionary<int, object> mixedData = new Dictionary<int, object>
            {
                { 1, "Pavan" },
                { 2, 100 },
                { 3, true }
            };

            Console.WriteLine("Mixed Data:");
            foreach (var pair in mixedData)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            // --------------------------
            // Updating and Merging Dictionaries
            // --------------------------
            Dictionary<int, string> additionalStudents = new Dictionary<int, string>
            {
                { 4, "Ankit" },
                { 5, "Suresh" }
            };

            foreach (var pair in additionalStudents)
            {
                if (!students.ContainsKey(pair.Key))
                {
                    students.Add(pair.Key, pair.Value);
                }
            }

            Console.WriteLine("After merging:");
            foreach (var pair in students)
            {
                Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
            }
            // Output:
            // ID: 1, Name: Pavan
            // ID: 3, Name: Amit
            // ID: 4, Name: Ankit
            // ID: 5, Name: Suresh

            // --------------------------
            // Removing by Condition using Linq
            // --------------------------
            foreach (var key in new List<int>(students.Keys))
            {
                if (key % 2 == 0) // Remove even keys
                {
                    students.Remove(key);
                }
            }

            Console.WriteLine("After removing even keys:");
            foreach (var pair in students)
            {
                Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
            }

            // --------------------------
            // Clearing the Dictionary
            // --------------------------
            students.Clear();
            Console.WriteLine($"Total students after clearing: {students.Count}"); // Output: 0
        }
    }
}
