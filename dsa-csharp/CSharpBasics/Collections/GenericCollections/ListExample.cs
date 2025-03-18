namespace dsa_csharp.CSharpBasics.Collections.GenericCollections
{
    public class ListExample
    {
        /*
            WHEN TO USE List<T>
            --------------------------------------------
            - Dynamic Size:
              - When you need a resizable array.
              - Example: Storing dynamic data like API responses or user-generated data.

            - Fast Access by Index:
              - Accessing elements by index is fast (O(1)).

            - Sorting and Searching:
              - Built-in support for sorting and searching.

            - Maintaining Insertion Order:
              - Elements are stored in the order they were added.

            LIMITATIONS
            --------------------------------------------
            - Slow Insertions/Removals in the Middle:
              - Inserting or removing elements in the middle requires shifting elements (O(n)).

            - Not Thread-Safe:
              - List<T> is not thread-safe. Use `ConcurrentBag<T>` or `ImmutableList<T>` for multi-threaded scenarios.

            PROBLEM-SOLVING SCENARIOS
            --------------------------------------------
            1. Dynamic Data Storage:
               - When the size of the collection is unknown beforehand.

            2. Sorting and Searching:
               - Use `Sort()` and `BinarySearch()` for quick data lookup.

            3. Maintaining Insertion Order:
               - When order of elements matters.

            4. Batch Processing:
               - Collecting large amounts of data for batch processing.

            5. Fast Index-Based Access:
               - Use when quick access to specific elements is required.
        */

        static void Main()
        {
            // --------------------------
            // List<int> - Basic Integer List
            // --------------------------
            List<int> numbers = new List<int>();

            // Add - Adds an element to the end of the list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            // AddRange - Adds multiple elements at once
            numbers.AddRange(new[] { 4, 5, 6 });

            // Insert - Inserts an element at a specific index (O(n))
            numbers.Insert(2, 10); // Insert 10 at index 2

            // Remove - Removes the first occurrence of an element (O(n))
            numbers.Remove(3);

            // RemoveAt - Removes the element at a specific index (O(n))
            numbers.RemoveAt(2); // Removes the element at index 2

            // Contains - Checks if an element exists in the list
            bool contains = numbers.Contains(5);
            Console.WriteLine($"List contains 5: {contains}"); // Output: True

            // IndexOf - Returns the index of the first occurrence of an element
            int index = numbers.IndexOf(5);
            Console.WriteLine($"Index of 5: {index}"); // Output: 3

            // Count - Returns the number of elements in the list
            int count = numbers.Count;
            Console.WriteLine($"Number of elements: {count}"); // Output: 5

            // Sort - Sorts the list in ascending order (O(n log n))
            numbers.Sort();

            // Reverse - Reverses the order of elements
            numbers.Reverse();

            // Iterate through the list using foreach
            Console.WriteLine("List elements:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item); // Output: Elements in reverse order
            }

            // Clear - Removes all elements from the list
            numbers.Clear();

            // --------------------------
            // List<string> - String-based List
            // --------------------------
            List<string> names = new List<string> { "Pavan", "Kumar", "Amit", "Thakur" };

            // Find - Finds the first element that matches a condition
            string found = names.Find(name => name.StartsWith("P"));
            Console.WriteLine($"Name starting with 'P': {found}"); // Output: Pavan

            // FindAll - Returns all elements that match a condition
            var matchingNames = names.FindAll(name => name.Contains("a"));
            Console.WriteLine("Names containing 'a':");
            foreach (var name in matchingNames)
            {
                Console.WriteLine(name); // Output: Pavan, Kumar, Amit, Thakur
            }

            // RemoveAll - Removes all elements that match a condition
            names.RemoveAll(name => name.Length < 5);

            // --------------------------
            // List<List<int>> - List of Lists (Nested Collections)
            // --------------------------
            List<List<int>> listOfLists = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 }
            };

            // Accessing nested list elements
            int firstElement = listOfLists[0][0];
            Console.WriteLine($"First element of first list: {firstElement}"); // Output: 1

            // Iterating through nested lists
            Console.WriteLine("Nested lists:");
            foreach (var innerList in listOfLists)
            {
                foreach (var item in innerList)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            // --------------------------
            // List<object> - Mixed Types
            // --------------------------
            List<object> mixedList = new List<object>();
            mixedList.Add(1);         // Integer
            mixedList.Add("Hello");   // String
            mixedList.Add(3.14);      // Double

            Console.WriteLine("Mixed List Elements:");
            foreach (var element in mixedList)
            {
                Console.WriteLine(element);
            }

            // --------------------------
            // Capacity Management
            // --------------------------
            List<int> capacityExample = new List<int>(100); // Pre-allocated capacity to avoid resizing
            for (int i = 0; i < 50; i++)
            {
                capacityExample.Add(i);
            }

            // Capacity - Returns the current allocated size of the list
            Console.WriteLine($"Current capacity: {capacityExample.Capacity}"); // Output: 100

            // TrimExcess - Reduces the capacity to the actual number of elements
            capacityExample.TrimExcess();
            Console.WriteLine($"Capacity after trimming: {capacityExample.Capacity}"); // Output: 50

        }
    }
}
