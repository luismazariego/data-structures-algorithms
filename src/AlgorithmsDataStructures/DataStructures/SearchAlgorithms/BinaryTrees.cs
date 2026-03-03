namespace AlgorithmsDataStructures.DataStructures.SearchAlgorithms;

public class BinaryTrees
{
    public TreeNode? Root { get; set; }
    
}

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}