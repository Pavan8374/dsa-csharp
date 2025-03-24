using System.Collections;

namespace dsa_csharp.CSharpBasics.Collections.NonGenericCollections
{
    public class ArrayListExample
    {
        static void ArrayListExampleMain()
        {
            ArrayList list = new ArrayList();

            list.Add(1);        // Adds an object to the end of the ArrayList.
            list.Add("Hello");  // Can store different types.
            list.Add(3.14);

            list.Insert(1, "World"); // Inserts an element at the specified index.

            list.Remove(3.14); // Removes the specified element.
            list.RemoveAt(1);  // Removes element at the specified index.
            list.Clear();      // Removes all elements from the ArrayList.

            var clonedList = list.Clone(); // Creates a shallow copy of the ArrayList.

            int count = list.Count; // Returns the number of elements in the ArrayList.

            bool contains = list.Contains("Hello"); // Returns true if element exists.

            // Iterate through the list
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
