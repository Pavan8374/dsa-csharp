
---

## **🔍 How to Identify the Right Approach for a Problem**
When solving problems, ask yourself **these key questions**:

### **1️⃣ Is the problem asking for the longest, shortest, or subarray/substring?**
- 🔹 **Use Sliding Window** if:
  - You need to find a subarray or substring with a specific condition.
  - The problem requires **finding the longest or shortest subarray** that meets some criteria.
  - Example: 
    - **Longest Substring Without Repeating Characters** ✅
    - **Minimum Size Subarray Sum** ✅

---

### **2️⃣ Are you dealing with two indices in an array (like left and right)?**
- 🔹 **Use Two Pointers** if:
  - You need to check pairs of elements from the array.
  - You need to move pointers inward based on conditions.
  - Example:
    - **Two Sum II (Sorted Array)** ✅
    - **Container With Most Water** ✅

---

### **3️⃣ Does the problem involve overlapping subproblems or optimal decisions?**
- 🔹 **Use Dynamic Programming (DP)** if:
  - The problem involves **choosing the best option** among multiple choices.
  - You need to **break a problem into subproblems** and reuse results.
  - Example:
    - **Longest Common Subsequence** ✅
    - **Knapsack Problem** ✅

---

### **4️⃣ Does the problem require frequent lookups or element counts?**
- 🔹 **Use Hashing (HashMap / HashSet)** if:
  - You need to check for duplicate elements.
  - You need **fast lookups** (like counting frequencies).
  - Example:
    - **Two Sum** ✅
    - **Group Anagrams** ✅

---

### **5️⃣ Do you need to process data in sorted order or find Kth largest/smallest?**
- 🔹 **Use Sorting or Heap (Priority Queue)** if:
  - The problem requires **finding top K elements**.
  - The problem mentions **median or closest elements**.
  - Example:
    - **Kth Largest Element in an Array (Heap)** ✅
    - **Merge K Sorted Lists (Heap)** ✅

---

## **🤔 How Are These Names Created?**
The names like **Sliding Window, Two Pointers, Dynamic Programming, etc.** come from:
1. **Computer Science Theory** 📚  
   - Example: **Dynamic Programming** was formally introduced by Richard Bellman.
2. **Common Patterns in Problems** 🔄  
   - Example: "Sliding Window" describes how we slide a fixed/variable-length window over an array.
3. **Competitive Programming & LeetCode** 💻  
   - These terms became standard as they were used in problem-solving discussions.

---

## **🛠 Quick Cheat Sheet for Problem Solving**
| Problem Type | Common Approach |
|-------------|----------------|
| **Substring/Subarray with condition** | Sliding Window |
| **Checking pairs in an array** | Two Pointers |
| **Counting elements or fast lookups** | HashMap / HashSet |
| **Finding "best way" in steps** | Dynamic Programming |
| **Sorting-based problems** | Sorting / Heap |
| **Tree traversal** | DFS / BFS |
| **Graph shortest path** | Dijkstra / BFS |

---

