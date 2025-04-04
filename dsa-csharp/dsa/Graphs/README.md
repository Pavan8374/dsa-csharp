# Graphs in Data Structures and Algorithms (DSA)

## Introduction
A **Graph** is a data structure used to represent relationships between objects. It consists of:
- **Nodes (Vertices)**: Entities in the graph.
- **Edges**: Connections between nodes.

Graphs are widely used to model real-world scenarios like social networks, navigation systems, and recommendation engines.

---

## History of Graphs
Graphs were first introduced by **Leonhard Euler** in 1736 to solve the famous **Seven Bridges of Königsberg** problem. This marked the beginning of **Graph Theory**, which has since been used extensively in computer science, mathematics, and various industries.

---

## Why Use Graphs?
Graphs are used when:
- Relationships exist between entities (e.g., social networks, road maps, web pages linking to each other).
- We need to find the best route (e.g., Google Maps, GPS navigation).
- We need to represent dependencies (e.g., task scheduling, dependency graphs in software).

---

## Types of Graphs
### 1. **Based on Edges:**
- **Undirected Graph**: Edges have no direction (e.g., Facebook friendships).
- **Directed Graph (Digraph)**: Edges have a direction (e.g., Twitter follows).

### 2. **Based on Weight:**
- **Unweighted Graph**: All edges have the same weight (e.g., social networks).
- **Weighted Graph**: Edges have weights (e.g., road networks with distances).

### 3. **Based on Cycles:**
- **Cyclic Graph**: Contains at least one cycle (e.g., flight routes).
- **Acyclic Graph**: No cycles (e.g., dependency graphs, trees).

### 4. **Based on Connectivity:**
- **Connected Graph**: All nodes are reachable.
- **Disconnected Graph**: Some nodes are unreachable.

---

## Graph Representation in C#
### 1. **Adjacency Matrix**
A 2D array where **matrix[i][j] = 1** if there is an edge from `i` to `j`, otherwise `0`.
```csharp
using System;

class GraphMatrix
{
    private int[,] adjMatrix;
    private int vertices;

    public GraphMatrix(int size)
    {
        vertices = size;
        adjMatrix = new int[size, size];
    }

    public void AddEdge(int src, int dest)
    {
        adjMatrix[src, dest] = 1;
        adjMatrix[dest, src] = 1; // For undirected graph
    }

    public void PrintGraph()
    {
        for (int i = 0; i < vertices; i++)
        {
            for (int j = 0; j < vertices; j++)
                Console.Write(adjMatrix[i, j] + " ");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        GraphMatrix graph = new GraphMatrix(5);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 4);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.PrintGraph();
    }
}
```

### 2. **Adjacency List** (More memory-efficient)
Using a dictionary or list to store edges.
```csharp
using System;
using System.Collections.Generic;

class GraphList
{
    private Dictionary<int, List<int>> adjList;

    public GraphList()
    {
        adjList = new Dictionary<int, List<int>>();
    }

    public void AddEdge(int src, int dest)
    {
        if (!adjList.ContainsKey(src))
            adjList[src] = new List<int>();
        adjList[src].Add(dest);
    }

    public void PrintGraph()
    {
        foreach (var vertex in adjList)
        {
            Console.Write(vertex.Key + " -> ");
            foreach (var edge in vertex.Value)
                Console.Write(edge + " ");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        GraphList graph = new GraphList();
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 4);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.PrintGraph();
    }
}
```

---

## Graph Traversal Algorithms
### 1. **Breadth-First Search (BFS)**
- Explores neighbors first before going deeper.
- Uses **Queue** (FIFO).
```csharp
using System;
using System.Collections.Generic;

class GraphBFS
{
    private Dictionary<int, List<int>> adjList = new();

    public void AddEdge(int src, int dest)
    {
        if (!adjList.ContainsKey(src))
            adjList[src] = new List<int>();
        adjList[src].Add(dest);
    }

    public void BFS(int start)
    {
        Queue<int> queue = new();
        HashSet<int> visited = new();
        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            Console.Write(node + " ");
            
            foreach (var neighbor in adjList.GetValueOrDefault(node, new List<int>()))
            {
                if (!visited.Contains(neighbor))
                {
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                }
            }
        }
    }
}
```

### 2. **Depth-First Search (DFS)**
- Explores as far as possible before backtracking.
- Uses **Stack** (LIFO).
```csharp
public void DFS(int node, HashSet<int> visited)
{
    if (visited.Contains(node)) return;
    Console.Write(node + " ");
    visited.Add(node);
    foreach (var neighbor in adjList.GetValueOrDefault(node, new List<int>()))
    {
        DFS(neighbor, visited);
    }
}
```

---

## Real-World Problems Solved by Graphs
### 1. **Shortest Path Problems**
   - **Dijkstra's Algorithm** (Google Maps, GPS Navigation)
   - **Bellman-Ford Algorithm**

### 2. **Minimum Spanning Tree**
   - **Kruskal’s Algorithm** (Network Design)
   - **Prim’s Algorithm**

### 3. **Topological Sorting**
   - **Dependency Resolution** (Task Scheduling, Build Systems like Makefile)

### 4. **Social Network Analysis**
   - **Connected Components** (Finding Friend Circles)

### 5. **Cycle Detection**
   - **Deadlock Detection** in Operating Systems

---

## Conclusion
Graphs are an essential part of DSA and are used in various real-world applications. Understanding their representation, traversal methods, and algorithms is key to solving complex problems efficiently.

Happy Coding! 🚀

