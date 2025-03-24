namespace dsa_csharp.CSharpBasics.Problems
{
    public class MaxMinArray
    {
        //Return minimum and maximum integer of the integer array.
        public static void Find_Min_Max_Array(int[] array)
        {
            var (min, max) = Result(array);
            var (min1, max1) = Result_Min_Max(array);
            Console.WriteLine($"Minimum:{min}, Maximum: {max}");
            Console.WriteLine($"Minimum:{min1}, Maximum: {max1}");
        }

        //Built in
        static (int min, int max) Result(int[] array)
        {
            if (!array.Any())
            {
                throw new ArgumentException("Array is empty");
            }

            int min = array.Min();
            int max = array.Max();
            return (min, max);
        }

        // Without built in

        static (int min, int max) Result_Min_Max(int[] array)
        {
            if (array == null || !array.Any())
            {
                throw new ArgumentException("Array is empty");
            }

            int length = array.Length;
            int min = array[0];
            int max = array[0];

            foreach (int i in array) 
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                   max = i;
                }
            }
            return (min, max);

        }

    }
}
