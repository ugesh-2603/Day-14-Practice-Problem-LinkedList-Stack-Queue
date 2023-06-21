using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Practice_Problem_LinkedList_Stack_Queue
{
    internal class LinkedList
    {
        private Node head; // Reference to the head of the linked list

        public void AddNode(int value)
        {
            Node newNode = new Node(value); // Create a new node with the given value

            if (head == null)
            {
                // If the list is empty, make the new node the head
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    // Traverse to the last node in the list
                    current = current.next;
                }

                // Append the new node to the last node
                current.next = newNode;
            }
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                // Print the data in each node
                Console.Write(current.data + " ");

                // Move to the next node
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
