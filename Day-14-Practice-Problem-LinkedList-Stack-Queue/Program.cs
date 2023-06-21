namespace Day_14_Practice_Problem_LinkedList_Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to LinkedList,Stack & Queue Problem ");

            LinkedList list = new LinkedList();

            // Add nodes to the list
            list.AddNode(56);
            list.AddNode(30);
            list.AddNode(70);

            // Print the list
            list.PrintList();
        }
    }
}