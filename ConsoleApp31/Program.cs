using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree kon = new BinaryTree();
            int[] on = new int[] { 10, 4, 2, 4, 8, 2, 4, 77, 8, 0, 1, 6 };
            Node fom = null;
            for (int i = 0; i < on.Length-1; i++)
            {
                fom = kon.insert(fom, on[i]);
            }
            Console.WriteLine(kon.MinValue(fom));
            Console.WriteLine(kon.MaxValue(fom));
        }
    }
    public class Node
    {
        public int value;
        public Node min, max;

        public Node(int integer)
        {
            value = integer;
            min = max = null;
        }
    }
    public class BinaryTree
    {
        public Node insert(Node root, int v)
        {
            if (root == null)
            {
                root = new Node(v);
            }
            else if (v < root.value)
            {
                root.min = insert(root.min, v);
            }
            else
            {
                root.max = insert(root.max, v);
            }

            return root;
        }

        public int MinValue(Node node)
        {
            Node rNode = node;

            while (rNode.min != null)
            {
                rNode = rNode.min;
            }
            return rNode.value;
        }
        public int MaxValue(Node node)
        {
            Node rNode = node;

            while (rNode.max != null)
            {
                rNode = rNode.max;
            }
            return rNode.value;
        }
    }
}
