using System.Collections;

namespace dsa_csharp.CSharpBasics.Collections.NonGenericCollections
{
    public class BitArrayExample
    {
        static void Main()
        {
            BitArray bits = new BitArray(5); // Creates a BitArray of size 5.

            bits.Set(0, true); // Sets the value at index 0 to true.
            bits.Set(1, false);
            bits.Set(2, true);

            bool value = bits.Get(0); // Gets the value at index 0.

            bits.SetAll(false); // Sets all values to false.

            int length = bits.Length; // Gets the length of the BitArray.

            foreach (bool bit in bits)
            {
                Console.WriteLine(bit);
            }
        }
    }
}
