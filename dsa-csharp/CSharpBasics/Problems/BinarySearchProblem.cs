namespace dsa_csharp.CSharpBasics.Problems
{
    internal class BinarySearchProblem
    {
        //Binary search works on a sorted array.

        public static void Find_IndexOfArrayByBinarySearch(int[] nums, int target)
        {
            int result = BinarySearch(nums, target);
            Console.WriteLine(result);
        }

        static int BinarySearch(int[] nums, int target)
        {
            //Ex: [1,3,56,45,78,2], target: 2 
            var sortedArray = nums.OrderBy(num => num).ToArray();
            //:   [1,2,3,45,56,78]

            int left = 0;                // index: 0
            int right = nums.Length - 1; // index: 5

            while (left <= right)       // 0 <= 5 => 0, 2,3,4,5 iterations
            {
                //1. mid = 6/2 = 3
                //2. mid = 2/2 = 1
                int mid = (left + right) / 2; 

                //1. At index 3 = 45 => false
                //2. At index 1 => 2 => true
                if (sortedArray[mid] == target) 
                {
                    return Array.IndexOf(nums, sortedArray[mid]);
                    //return mid;
                }

                // 1. 45 < 2 //false 
                if (sortedArray[mid] < target) 
                {
                    left = mid + 1; //means it will start its index mid + 1
                }
                else
                {
                    //1.right => 3 - 1 = 2 now the right is replaced with existing right 5
                    right = mid - 1;  //means the right be started from mid - 1
                }
            }
            return -1;
        }


        //Practice to remember
        static int FindIndex(int[] arr, int target)
        {
            var sortedArray = arr.OrderBy(num => num).ToArray();
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right) 
            { 
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                if (arr[mid] < target)
                {
                    left = mid + 1;   //means it will start its index mid + 1
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;

        }
    }
}
