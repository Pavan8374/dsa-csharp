namespace dsa_csharp.CSharpBasics.Collections.GenericCollections
{
    /// <summary>
    /// HashSet<T> is a collection that contains only **unique elements** and allows **fast lookup**.
    /// 
    /// When to Use:
    /// - When you need to store unique items.
    /// - When you require fast lookup, insertion, and deletion (average O(1) time complexity).
    /// - When ordering is NOT required.
    /// - Ideal for set operations like Union, Intersection, and Difference.
    /// 
    /// Internal Implementation:
    /// - Backed by a **hash table**.
    /// - Uses **hashing** for quick lookup and insertion.
    /// - Handles collisions using **chaining** (storing elements in linked lists).
    /// 
    /// Notes:
    /// - If two objects have the same hash code, they are stored in the same bucket.
    /// - Uses **GetHashCode()** and **Equals()** to determine object uniqueness.
    /// </summary>
    public class HashSetExample
    {
        static void Main()
        {
            // Create a HashSet of integers
            HashSet<int> numbers = new HashSet<int>();

            // Add elements to HashSet
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(3); // Duplicate will NOT be added since HashSet allows only unique elements

            Console.WriteLine("HashSet elements:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Remove an element
            numbers.Remove(2);

            // Check if an element exists
            bool containsThree = numbers.Contains(3); // true

            // Get the number of elements in the HashSet
            int count = numbers.Count;

            // Clear all elements
            numbers.Clear();

            // UnionWith Example: Combines two sets (removes duplicates)
            HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
            HashSet<int> setB = new HashSet<int> { 3, 4, 5 };

            setA.UnionWith(setB); // Result: {1, 2, 3, 4, 5}

            Console.WriteLine("\nUnion Result:");
            foreach (var num in setA)
            {
                Console.WriteLine(num);
            }

            // IntersectWith Example: Keeps only common elements
            setA = new HashSet<int> { 1, 2, 3 };
            setB = new HashSet<int> { 3, 4, 5 };

            setA.IntersectWith(setB); // Result: {3}

            Console.WriteLine("\nIntersection Result:");
            foreach (var num in setA)
            {
                Console.WriteLine(num);
            }

            // ExceptWith Example: Removes elements present in another set
            setA = new HashSet<int> { 1, 2, 3 };
            setB = new HashSet<int> { 2, 3 };

            setA.ExceptWith(setB); // Result: {1}

            Console.WriteLine("\nDifference Result:");
            foreach (var num in setA)
            {
                Console.WriteLine(num);
            }

            // SymmetricExceptWith Example: Keeps elements that are NOT in both sets
            setA = new HashSet<int> { 1, 2, 3 };
            setB = new HashSet<int> { 3, 4, 5 };

            setA.SymmetricExceptWith(setB); // Result: {1, 2, 4, 5}

            Console.WriteLine("\nSymmetric Difference Result:");
            foreach (var num in setA)
            {
                Console.WriteLine(num);
            }

            // Comparison Example: Comparing two sets
            setA = new HashSet<int> { 1, 2, 3 };
            setB = new HashSet<int> { 1, 2, 3 };

            bool isEqual = setA.SetEquals(setB); // true (same elements)

            // Copy Example
            HashSet<int> copySet = new HashSet<int>(setA);

            // Custom Object Example:
            // When using custom objects, override Equals() and GetHashCode()
            HashSet<Person> people = new HashSet<Person>
            {
                new Person { Name = "Pavan", Age = 24 },
                new Person { Name = "Kumar", Age = 25 }
            };

            // Adding duplicate object (not allowed if Equals() and GetHashCode() are properly defined)
            people.Add(new Person { Name = "Pavan", Age = 24 }); // Won't be added since it's a duplicate

            Console.WriteLine("\nCustom Object HashSet:");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override bool Equals(object obj)
            {
                if (obj is Person person)
                {
                    return this.Name == person.Name && this.Age == person.Age;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Name, Age);
            }
        }
    }
}
