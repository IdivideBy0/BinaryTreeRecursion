using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{

    public class Node
    {
        public int Data { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
    }


    class Program
    {

        public static void printLeafNodes(Node root)
        {
            // If node is null, return  
            if (root == null)
            {
                return;
            }

            // If node is a leaf, print it's int data  
            if (root.LeftNode == null && root.RightNode == null)
            {
                Console.Write(root.Data + " ");
                return;
            }

            // If left child exists, check for leaf  
            // recursively  
            if (root.LeftNode != null)
            {
                printLeafNodes(root.LeftNode);
            }

            // If right child exists, check for leaf  
            // recursively  
            if (root.RightNode != null)
            {
                printLeafNodes(root.RightNode);
            }
        }




        static void Main(string[] args)
        {
            // load values
            var treeNode = new Node() { Data = 1 };
            treeNode.LeftNode = new Node() { Data = 2 };
            treeNode.RightNode = new Node() { Data = 3 };
            treeNode.LeftNode.LeftNode = new Node() { Data = 4 };
            treeNode.RightNode.LeftNode = new Node() { Data = 5 };
            treeNode.RightNode.RightNode = new Node() { Data = 8 };
            treeNode.RightNode.LeftNode.LeftNode = new Node() { Data = 6 };
            treeNode.RightNode.LeftNode.RightNode = new Node() { Data = 7 };
            treeNode.RightNode.RightNode.LeftNode = new Node() { Data = 9 };
            treeNode.RightNode.RightNode.RightNode = new Node() { Data = 10 };



            //Console.Write(treeNode.RightNode.RightNode.RightNode.Data);

            printLeafNodes(treeNode);

        }
    }
}
