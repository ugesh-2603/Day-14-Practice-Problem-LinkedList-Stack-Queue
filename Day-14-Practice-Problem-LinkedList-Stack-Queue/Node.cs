using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Practice_Problem_LinkedList_Stack_Queue
{
    internal class Node
    {
        public int data; // Data stored in the node
        public Node next; // Reference to the next node

        public Node(int value)
        {
            data = value; // Initialize the data with the given value
            next = null; // Set the next reference to null
        }
    }
}
