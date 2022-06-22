using System;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List Program \n - - - - - - - - - - - - - - - - -");
            LinkedList linkedlist = new LinkedList();
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);
            Node node4 = new Node(40);

            //linkedlist.AppendNode(node1);
            //linkedlist.AppendNode(node2);
            //linkedlist.AppendNode(node3);




            linkedlist.AddNode(node1);
            linkedlist.AddNode(node2);
            linkedlist.AddNode(node3);
            //Console.WriteLine("Inserting node after 30");
            linkedlist.InsertNode(node4, node2);
            //linkedlist.InsertNode(node2, node3);

            //linkedlist.DeleteNodeAtFirst();
            //linkedlist.DeleteNodeAtLast();
            Console.WriteLine("Before deleting ");
            linkedlist.Display();
            linkedlist.DeleteNodeAtParticularPosition(40);
            Console.WriteLine("\nAfter deleting ");
            linkedlist.Display();
            linkedlist.ListSize();
            //Console.WriteLine("\n====================================");

            //if (linkedlist.Search(45) == true)
            //{
            //    Console.WriteLine("the value is present in the linked list");
            //}
            //else
            //{
            //    Console.WriteLine("the value is not present in the linked list ");
            //}
            
        }
    }
}