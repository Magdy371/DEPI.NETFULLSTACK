using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchGraphs
{
    using System;
    using System.Collections.Generic;
#nullable disable

    internal class BFSG
    {
        // Generic BFS function
        public static List<T> BreadthFirstSearch<T>(T start, Func<T, List<T>> getNeighbors, Action<T> processNode = null)
        {
            // Track visited nodes to avoid cycles
            HashSet<T> visited = new HashSet<T>();
            // Queue for BFS traversal
            Queue<T> queue = new Queue<T>();
            // List to store the traversal order
            List<T> traversalOrder = new List<T>();

            // Start with the initial node
            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                // Dequeue the current node
                T currentNode = queue.Dequeue();
                traversalOrder.Add(currentNode);

                // Process the current node (if a callback is provided)
                processNode?.Invoke(currentNode);

                // Explore all neighbors
                foreach (T neighbor in getNeighbors(currentNode))
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return traversalOrder;
        }
    }
}
