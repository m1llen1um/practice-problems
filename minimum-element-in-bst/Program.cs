using System;

namespace minimum_element_in_bst
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)
            {
                BinaryTreeNode<int> root = null;
                int sizeOfArray = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[sizeOfArray];
                arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);

                for (int i = 0; i < sizeOfArray; i++)
                {
                    root = BinaryTree<int>.AddNode(root, arr[i]);
                }

                Console.WriteLine(BinaryTree<int>.MinValue(root));
            }
        }
    }
}
