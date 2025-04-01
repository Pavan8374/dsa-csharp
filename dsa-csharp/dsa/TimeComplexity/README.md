# Time and Space Complexity

## Introduction
Time and space complexity measure the efficiency of an algorithm in terms of execution time and memory usage. These complexities are analyzed based on input size `n` and are commonly expressed using Big-O notation.

## Time Complexity (Ascending Order)
Time complexity describes how the running time of an algorithm increases with input size.

### **1. O(1) - Constant Time**
- Execution time remains constant regardless of input size.
- Example:
  ```csharp
  int firstElement(int[] arr) {
      return arr[0];
  }
  ```

### **2. O(log n) - Logarithmic Time**
- Execution time increases logarithmically with input size.
- Often found in divide-and-conquer algorithms like binary search.
- Example:
  ```csharp
  int BinarySearch(int[] arr, int target) {
      int left = 0, right = arr.Length - 1;
      while (left <= right) {
          int mid = left + (right - left) / 2;
          if (arr[mid] == target) return mid;
          else if (arr[mid] < target) left = mid + 1;
          else right = mid - 1;
      }
      return -1;
  }
  ```

### **3. O(n) - Linear Time**
- Execution time grows proportionally to input size.
- Example:
  ```csharp
  void PrintElements(int[] arr) {
      foreach (var item in arr) {
          Console.WriteLine(item);
      }
  }
  ```

### **4. O(n log n) - Linearithmic Time**
- Slightly slower than linear time, common in sorting algorithms like Merge Sort.
- Example (Merge Sort):
  ```csharp
  void MergeSort(int[] arr) {
      if (arr.Length <= 1) return;
      int mid = arr.Length / 2;
      int[] left = arr[..mid];
      int[] right = arr[mid..];
      MergeSort(left);
      MergeSort(right);
      Merge(arr, left, right);
  }
  ```

### **5. O(n²) - Quadratic Time**
- Execution time grows quadratically, common in nested loops.
- Example (Bubble Sort):
  ```csharp
  void BubbleSort(int[] arr) {
      for (int i = 0; i < arr.Length; i++) {
          for (int j = 0; j < arr.Length - i - 1; j++) {
              if (arr[j] > arr[j + 1]) {
                  (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
              }
          }
      }
  }
  ```

### **6. O(2ⁿ) - Exponential Time**
- Growth doubles with each increment of `n`, common in recursive algorithms like Fibonacci.
- Example:
  ```csharp
  int Fibonacci(int n) {
      if (n <= 1) return n;
      return Fibonacci(n - 1) + Fibonacci(n - 2);
  }
  ```

### **7. O(n!) - Factorial Time**
- Growth explodes factorially, found in brute-force algorithms like traveling salesman problem (TSP).
- Example:
  ```csharp
  void Permutations(string str, string prefix = "") {
      if (str.Length == 0) {
          Console.WriteLine(prefix);
      } else {
          for (int i = 0; i < str.Length; i++) {
              Permutations(str.Remove(i, 1), prefix + str[i]);
          }
      }
  }
  ```

## Space Complexity (Ascending Order)
Space complexity measures the memory required by an algorithm as input size grows.

### **1. O(1) - Constant Space**
- Uses fixed memory regardless of input size.
- Example:
  ```csharp
  int GetSum(int a, int b) {
      return a + b;
  }
  ```

### **2. O(log n) - Logarithmic Space**
- Occurs in recursive algorithms that divide the problem.
- Example: Recursive Binary Search.

### **3. O(n) - Linear Space**
- Memory usage grows linearly with input size.
- Example:
  ```csharp
  int[] CopyArray(int[] arr) {
      return arr.ToArray();
  }
  ```

### **4. O(n²) - Quadratic Space**
- Example: Storing all pairs in a matrix.

### **5. O(2ⁿ) - Exponential Space**
- Example: Storing all subsets of an array.

### **6. O(n!) - Factorial Space**
- Example: Generating and storing all permutations.

## Conclusion
Understanding time and space complexity helps in designing efficient algorithms. Always aim for the lowest possible complexity for best performance.
