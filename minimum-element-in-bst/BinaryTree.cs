using System;

public class BinaryTreeNode<T>
{
    public BinaryTreeNode<T> LeftNode { get; set; }

    public BinaryTreeNode<T> RightNode { get; set; }

    public T Data { get; set; }
}

public static class BinaryTree<T> where T : IComparable
{
    public static BinaryTreeNode<T> AddNode(T data)
    {
        return new BinaryTreeNode<T>
        {
            Data = data,
            LeftNode = null,
            RightNode = null
        };
    }

    public static BinaryTreeNode<T> AddNode(BinaryTreeNode<T> root, T data)
    {
        if (root == null)
        {
            root = AddNode(data);
        }

        if (root.Data.CompareTo(data) > 0)
        {
            root.LeftNode = AddNode(root.LeftNode, data);
        }
        else
        {
            root.RightNode = AddNode(root.RightNode, data);
        }

        return root;
    }

    public static T MinValue(BinaryTreeNode<T> root)
    {
        T minVal = default(T);
        if (root == null)
        {
            return minVal;
        }

        var currentNode = root;
        minVal = currentNode.Data;

        while (currentNode.LeftNode != null)
        {
            minVal = currentNode.Data;
            currentNode = currentNode.LeftNode;
        }

        return minVal;
    }
}