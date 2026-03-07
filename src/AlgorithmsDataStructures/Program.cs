using AlgorithmsDataStructures.DataStructures;

NodeA leaf1 = new NodeA(null, null);
        NodeA leaf2 = new NodeA(null, null);
        NodeA node = new NodeA(leaf1, null);
        NodeA root = new NodeA(node, leaf2);

        Console.WriteLine(root.Height());