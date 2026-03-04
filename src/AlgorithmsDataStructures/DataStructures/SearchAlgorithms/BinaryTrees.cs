using System;

namespace AlgorithmsDataStructures.DataStructures.SearchAlgorithms;

public class BinaryTrees
{
    public TreeNode? Root { get; set; }
    
    public void Insert(int key, string value)
    {
        if (Root is null)
        {
            Root = new TreeNode(key, value);
            return;
        }
        InsertItem(Root, key, value);
    }

    public string Find(int key)
    {
        TreeNode? node = FindNode(Root, key);
        return node is not null ? node.Value : string.Empty;
    }

    private static TreeNode? FindNode(TreeNode? node, int key)
    {
        if (node is null) return null;
        if (key == node.Key) return node;
        if (key < node.Key) return FindNode(node.Left, key);
        return FindNode(node.Right, key);
    }

    private static TreeNode InsertItem(TreeNode? node, int key, string value)
    {
        if (node is null)
        {
            return new TreeNode(key, value);
        }
        if (key < node.Key)
        {
            node.Left = InsertItem(node.Left, key, value);
        }
        else
        {
            node.Right = InsertItem(node.Right, key, value);
        }
        return node;
    }

    public void Display()
    {
        if (Root is null)
        {
            Console.WriteLine("(empty tree)");
            return;
        }
        PrintSideways(Root, "", true);
    }

    public void PrintInOrder()
    {
        if (Root is null)
        {
            Console.WriteLine("(empty tree)");
            return;
        }
        PrintInOrder(Root);
    }

    private static void PrintInOrder(TreeNode? node)
    {
        if (node is null) return;
        PrintInOrder(node.Left);
        Console.WriteLine($"{node.Key}: {node.Value}");
        PrintInOrder(node.Right);
    }

    public void PrintPreOrder()
    {
        if (Root is null)
        {
            Console.WriteLine("(empty tree)");
            return;
        }
        PrintPreOrder(Root);
    }

    private static void PrintPreOrder(TreeNode? node)
    {
        if (node is null) return;
        Console.WriteLine($"{node.Key}: {node.Value}");
        PrintPreOrder(node.Left);
        PrintPreOrder(node.Right);
    }

    public void PrintPostOrder()
    {
        if (Root is null)
        {
            Console.WriteLine("(empty tree)");
            return;
        }
        PrintPostOrder(Root);
    }

    private static void PrintPostOrder(TreeNode? node)
    {
        if (node is null) return;
        PrintPostOrder(node.Left);
        PrintPostOrder(node.Right);
        Console.WriteLine($"{node.Key}: {node.Value}");
    }

    private static void PrintSideways(TreeNode? node, string indent, bool isRight)
    {
        if (node == null) return;

        PrintSideways(node.Right, indent + (isRight ? "        " : "│       "), true);

        Console.Write(indent);
        Console.Write(isRight ? "┌────" : "└────");
        Console.WriteLine($"{node.Key}: {node.Value}");

        PrintSideways(node.Left, indent + (isRight ? "│       " : "        "), false);
    }
}

public class TreeNode
{
    public int Key { get; init; }
    public string Value { get; init; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int key, string value)
    {
        Key = key;
        Value = value;  
        Left = null;
        Right = null;
    }
}