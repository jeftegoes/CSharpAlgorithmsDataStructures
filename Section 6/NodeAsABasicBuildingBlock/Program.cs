using System;

namespace NodeAsABasicBuildingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new Node() { Value = 5 };
            var second = new Node() { Value = 1 };

            first.Next = second;

            var third = new Node() { Value = 3 };
            second.Next = third;

            PrintOutLinkedList(first);
        }

        private static void PrintOutLinkedList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
