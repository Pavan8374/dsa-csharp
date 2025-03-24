using System.Collections;

namespace dsa_csharp.CSharpBasics.Collections.NonGenericCollections
{
    public class QueueExample
    {
        static void QueueExampleMain()
        {
            Queue queue = new Queue();

            queue.Enqueue(1); // Adds an object to the end of the queue.
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue(); // Removes and returns the object at the beginning.

            int count = queue.Count; // Number of objects in the queue.

            var frontElement = queue.Peek(); // Returns the object at the front without removing it.

            bool contains = queue.Contains(2); // Returns true if object exists.

            queue.Clear(); // Removes all objects.

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
