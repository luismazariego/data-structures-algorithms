using System;
namespace AlgorithmsDataStructures.DataStructures;

public class NodeA
{
    public NodeA? LeftChild { get; private set; }
    public NodeA? RightChild { get; private set; }

    public NodeA(NodeA? leftChild, NodeA? rightChild)
    {
        this.LeftChild = leftChild;
        this.RightChild = rightChild;
    }

    public int Height()
    {
        // Height is measured in edges: leaf = 0, empty child = -1.
        int leftHeight = LeftChild != null ? LeftChild.Height() : -1;
        int rightHeight = RightChild != null ? RightChild.Height() : -1;

        return Math.Max(leftHeight, rightHeight) + 1;
    }

    // public static void Main(string[] args)
    // {
    //     NodeA leaf1 = new NodeA(null, null);
    //     NodeA leaf2 = new NodeA(null, null);
    //     NodeA node = new NodeA(leaf1, null);
    //     NodeA root = new NodeA(node, leaf2);

    //     Console.WriteLine(root.Height());
    // }
}