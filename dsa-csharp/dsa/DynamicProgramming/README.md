# Dynamic Programming in C#

## Introduction
Dynamic Programming (DP) is a technique used to solve problems by breaking them down into smaller subproblems and storing their results to avoid redundant computations. It is especially useful in optimization problems where overlapping subproblems exist.

## History
The term "Dynamic Programming" was coined by Richard Bellman in the 1950s. Initially, it was used for solving complex decision-making problems in economics and operations research. Today, DP is widely used in computer science, artificial intelligence, and game development.

## Why Use Dynamic Programming?
1. **Optimization**: Finds the most efficient solution by breaking problems into overlapping subproblems.
2. **Avoids Repetitive Computation**: Stores results of subproblems to use later (memoization or tabulation).
3. **Improves Performance**: Reduces time complexity from exponential (e.g., O(2^n)) to polynomial (e.g., O(n^2) or O(n)).

## When to Use Dynamic Programming?
- When a problem has **overlapping subproblems** (repeated calculations of the same subproblems).
- When a problem has **optimal substructure** (the optimal solution of a problem depends on optimal solutions of its subproblems).

## Types of Dynamic Programming Approaches
1. **Top-Down (Memoization)**
   - Uses recursion and stores computed results.
   - Saves time by avoiding recomputation.
   - Example: Recursive Fibonacci with memoization.

2. **Bottom-Up (Tabulation)**
   - Uses an iterative approach and stores solutions in a table.
   - Efficient in terms of space and execution.
   - Example: Iterative Fibonacci using a DP table.

---

## Examples

### Example 1: Fibonacci Series (Top-Down Approach)
```csharp
using System;
using System.Collections.Generic;

class FibonacciDP
{
    static Dictionary<int, long> memo = new Dictionary<int, long>();
    
    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        
        if (memo.ContainsKey(n))
            return memo[n];
        
        memo[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
        return memo[n];
    }
    
    static void Main()
    {
        Console.WriteLine(Fibonacci(10)); // Output: 55
    }
}
```

### Example 2: Fibonacci Series (Bottom-Up Approach)
```csharp
using System;

class FibonacciBottomUp
{
    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        
        long[] dp = new long[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        
        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        
        return dp[n];
    }
    
    static void Main()
    {
        Console.WriteLine(Fibonacci(10)); // Output: 55
    }
}
```

### Example 3: 0/1 Knapsack Problem
```csharp
using System;

class KnapsackDP
{
    static int Knapsack(int[] weights, int[] values, int capacity, int n)
    {
        int[,] dp = new int[n + 1, capacity + 1];
        
        for (int i = 0; i <= n; i++)
        {
            for (int w = 0; w <= capacity; w++)
            {
                if (i == 0 || w == 0)
                    dp[i, w] = 0;
                else if (weights[i - 1] <= w)
                    dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                else
                    dp[i, w] = dp[i - 1, w];
            }
        }
        return dp[n, capacity];
    }
    
    static void Main()
    {
        int[] weights = { 2, 3, 4, 5 };
        int[] values = { 3, 4, 5, 6 };
        int capacity = 5;
        int n = weights.Length;
        
        Console.WriteLine(Knapsack(weights, values, capacity, n)); // Output: 7
    }
}
```

## Conclusion
Dynamic Programming is a powerful technique used to optimize problems with overlapping subproblems. Using either **memoization** (top-down) or **tabulation** (bottom-up), we can significantly reduce computation time. DP is commonly applied in problems like Fibonacci, Knapsack, Longest Common Subsequence, and more.

