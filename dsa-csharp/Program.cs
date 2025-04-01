using dsa_csharp.CSharpBasics.Problems;
using dsa_csharp.dsa.Arrays;
using dsa_csharp.dsa.LeetCodeProblems;
using dsa_csharp.dsa.LinkedLists;
using dsa_csharp.dsa.Strings.SlidingWindow;

namespace dsa_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataType.Run();
            //ReverseAString.ReverseString();
            //PalindromeCheck.Palindrome_Check();
            //FizzBuzz.Fizz_Buzz();
            //FindFactorial.Find_Factorial();
            //MaxMinArray.Find_Min_Max_Array([-45, -78, -9000, -900000,1, -10000, -2, 3, -90]);
            //CountOccurrencesOfCharacter.CountOccurence();
            //RemoveDuplicatesFromAnArray.RemoveDuplicates([1, 2, 3, 4, 3, 3, 35, 67, 56, 3]);
            //MissingNumberInArray.FindMissingNumber([1,12,3,4,5,7,8,9,10,11,2]);
            //CheckPrimeNumber.CheckIfPrimeNumber();
            //TwoSumProblem.Two_Sum([1,2,3,8,5,6], 14);


            //LinkedList<int> l = new LinkedList<int>();
            //l.AddLast(10);
            //// Adds at the beginning
            //l.AddFirst(20);
            //// Adds at the end
            //l.AddLast(30);
            //// Adds at the end
            //l.AddLast(40);

            //ReverseALinkedList.Reverse_LinkedList(l);

            //FindDuplicateInArray.Find_Duplicate_In_Array([1,2,3,4,5,2,4]);

            //BinarySearchProblem.Find_IndexOfArrayByBinarySearch([34,5,67,45,1,2,3,56,100,102,47,35], 1);


            //var node = new AddTwoNumbersProblem();

            //int length = LongestSubString.Longest_String("abcabcd");
            //Console.WriteLine($"Result: {length}");


            //double median = MedianOfTwoSortedArrays.FindMedianSortedArrays([22, 10, 19, 5,1], [18, 4, 6, 3, 7, 14]);
            //double median = MedianOfTwoSortedArrays.FindMedianSortedArrays([1,2,3,4,5], [6,7,8,9,10]);
            //double median = MedianOfTwoSortedArrays.Find_MedianSortedArrays([1, 2], [3, 4]);
            //Console.WriteLine($"Result: {median}");

            var str = LongestPalindromicSubstring.Find_Longest_Palindrometic_Substring("aba");
            Console.WriteLine($"Result: {str}");
        }
    }
}
