// See https://aka.ms/new-console-template for more information
using AlgorithmsDataStructures.DataStructures;
using AlgorithmsDataStructures.DataStructures.SearchAlgorithms;
using AlgorithmsDataStructures.DataStructures.SortAlgorithms;

//Console.WriteLine("Hello, World!");

HashTables hashTable = new HashTables(10);
hashTable.Insert("apple", "apple");
hashTable.Insert("banana", "banana");
hashTable.Insert("orange", "orange");
hashTable.Insert("grape", "grape");
Console.WriteLine(hashTable.Find("banana")); // Output: "banana"
Console.WriteLine(hashTable.Find("pear"));   // Output: ""
// hashTable.Insert("apple", "apple"); // Collision occurred for value 'apple' at index 5. Value 'apple' is already stored at this index.