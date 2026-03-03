// See https://aka.ms/new-console-template for more information
using AlgorithmsDataStructures.DataStructures;
using AlgorithmsDataStructures.DataStructures.SearchAlgorithms;

//Console.WriteLine("Hello, World!");

var search = new BinarySearchArray();
var array = new int[] { -20,-15,2,7,20,30,54 };
var target = 2;
var found = search.Search(array, target, true);
Console.WriteLine($"Target {target} found: {found}");