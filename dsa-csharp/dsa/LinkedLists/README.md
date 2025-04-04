# Linked List in Data Structures (DSA) - C#

## 📌 Introduction
A **Linked List** is a linear data structure where elements (nodes) are connected using pointers. Unlike arrays, Linked Lists are dynamic and do not require a predefined size.

### 🔹 How It Works:
Each node in a Linked List consists of:
1. **Data** – Stores the actual value.
2. **Pointer** – Stores the address of the next node.

### 🔹 Types of Linked Lists:
1. **Singly Linked List** - Each node points to the next node.
2. **Doubly Linked List** - Each node has two pointers (previous and next).
3. **Circular Linked List** - The last node connects back to the first node.

## 🚀 Why Use a Linked List?
🔹 **Efficient Insertions/Deletions** - Unlike arrays, inserting or deleting elements does not require shifting.
🔹 **Dynamic Memory Allocation** - Can grow or shrink dynamically.
🔹 **Better than Arrays in Certain Scenarios** - When frequent insertions/deletions are required.

## 🛠 Problems Solved by Linked List
Linked Lists help in solving problems related to:
- **Dynamic memory allocation** (Heap memory management)
- **Implementation of stacks & queues**
- **Graphs (Adjacency list representation)**
- **LRU Cache (Least Recently Used Cache)**
- **Polynomial Arithmetic (Handling large expressions efficiently)**

### 🏛 Historical Background
The concept of Linked Lists was introduced by **Allen Newell, Cliff Shaw, and Herbert A. Simon** in the 1950s.

---

## 📚 Deep Dive into Linked List
### 1️⃣ Singly Linked List (Basic Implementation in C#)
```csharp
using System;

class Node {
    public int Data;
    public Node Next;
    public Node(int data) {
        Data = data;
        Next = null;
    }
}

class LinkedList {
    private Node head;
    
    public void InsertAtEnd(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.Next != null) {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }
    
    public void PrintList() {
        Node temp = head;
        while (temp != null) {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("NULL");
    }
}

class Program {
    static void Main() {
        LinkedList list = new LinkedList();
        list.InsertAtEnd(10);
        list.InsertAtEnd(20);
        list.InsertAtEnd(30);
        list.PrintList(); // Output: 10 -> 20 -> 30 -> NULL
    }
}
```

### 2️⃣ Doubly Linked List (With Insert & Delete)
```csharp
using System;

class DNode {
    public int Data;
    public DNode Prev, Next;
    public DNode(int data) {
        Data = data;
        Prev = Next = null;
    }
}

class DoublyLinkedList {
    private DNode head;
    
    public void InsertAtBeginning(int data) {
        DNode newNode = new DNode(data);
        if (head != null) {
            head.Prev = newNode;
            newNode.Next = head;
        }
        head = newNode;
    }
    
    public void DeleteNode(int key) {
        DNode temp = head;
        while (temp != null && temp.Data != key) {
            temp = temp.Next;
        }
        if (temp == null) return;
        if (temp.Prev != null) temp.Prev.Next = temp.Next;
        if (temp.Next != null) temp.Next.Prev = temp.Prev;
        if (temp == head) head = temp.Next;
    }
    
    public void PrintList() {
        DNode temp = head;
        while (temp != null) {
            Console.Write(temp.Data + " <-> ");
            temp = temp.Next;
        }
        Console.WriteLine("NULL");
    }
}

class Program {
    static void Main() {
        DoublyLinkedList list = new DoublyLinkedList();
        list.InsertAtBeginning(10);
        list.InsertAtBeginning(20);
        list.InsertAtBeginning(30);
        list.PrintList(); // Output: 30 <-> 20 <-> 10 <-> NULL
        
        list.DeleteNode(20);
        list.PrintList(); // Output: 30 <-> 10 <-> NULL
    }
}
```

### 3️⃣ Circular Linked List (With Insertion)
```csharp
using System;

class CNode {
    public int Data;
    public CNode Next;
    public CNode(int data) {
        Data = data;
        Next = null;
    }
}

class CircularLinkedList {
    private CNode last;
    
    public void Insert(int data) {
        CNode newNode = new CNode(data);
        if (last == null) {
            last = newNode;
            last.Next = last;
        } else {
            newNode.Next = last.Next;
            last.Next = newNode;
            last = newNode;
        }
    }
    
    public void PrintList() {
        if (last == null) return;
        CNode temp = last.Next;
        do {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        } while (temp != last.Next);
        Console.WriteLine("(Back to Head)");
    }
}

class Program {
    static void Main() {
        CircularLinkedList list = new CircularLinkedList();
        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.PrintList(); // Output: 10 -> 20 -> 30 -> (Back to Head)
    }
}
```

## 🔥 When to Use Linked Lists?
| Use Case | Linked List or Array? | Reason |
|----------|----------------------|--------|
| Fast Insertions/Deletions | ✅ Linked List | No shifting required |
| Fast Access by Index | ❌ Array | O(1) access time |
| Dynamic Size | ✅ Linked List | No need for predefined size |
| Memory Efficiency | ❌ Array | No extra pointer overhead |

## 🎯 Famous Linked List Problems
1. **Reverse a Linked List**
2. **Detect Loop in a Linked List**
3. **Merge Two Sorted Linked Lists**
4. **Find Middle Element of a Linked List**
5. **Remove Nth Node from End**
6. **LRU Cache Implementation**

## 📌 Conclusion
Linked Lists are an essential part of data structures, useful in scenarios requiring dynamic memory allocation and efficient insertions/deletions. Understanding them deeply will help in solving many real-world problems efficiently.

Happy Coding! 🚀

