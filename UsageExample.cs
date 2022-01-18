using BSTTraversalLibrary.TreeTraversals;
using System;
using System.Collections.Generic;

namespace BSTTraversalLibrary
{
    public class UsageExample
    {
        static void Main(string[] args)
        {
            List<int> valueList = new List<int>();
            BST tree = new BST();

            Console.WriteLine("Enter no. of nodes");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Node {0}. ", i);
                valueList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // create tree 
            tree.Create(valueList);

            tree.Traverse<PreOrder>();
            tree.Traverse<InOrder>();
            tree.Traverse<PostOrder>();
        }
    }
}