// See https://aka.ms/new-console-template for more information
using AlgorithmsDataStructures.DataStructures;
using AlgorithmsDataStructures.DataStructures.SearchAlgorithms;

//Console.WriteLine("Hello, World!");

Queues queue = new Queues(5);
queue.Enqueue("A");
queue.Enqueue("B");
queue.Enqueue("C");
Console.WriteLine(queue.Dequeue()); // Output: A
Console.WriteLine(queue.Peek()); // Output: B
queue.Enqueue("D");
queue.Enqueue("E");
queue.Enqueue("F"); // Output: Queue is full. Cannot enqueue new value.
Console.WriteLine(queue.Dequeue()); // Output: B
Console.WriteLine(queue.Dequeue()); // Output: C