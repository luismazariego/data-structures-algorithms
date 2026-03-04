namespace AlgorithmsDataStructures.DataStructures;

public class HashTables
{
    private string[] _hashTable { get; set; }
    public HashTables(int size)
    {
        _hashTable = new string[size];
    }

    public void Insert(string key, string value)
    {
        int hash = HashFunction(key);
        if (!string.IsNullOrEmpty(_hashTable[hash]))
        {
            Console.WriteLine($"Collision occurred for value '{value}' " 
                + $"at index {hash}. Value '{_hashTable[hash]}' is already stored at this index.");
        }
        _hashTable[hash] = value;
    }

    public string Find(string key)
    {
        int hash = HashFunction(key);
        return _hashTable[hash] == key ?
             _hashTable[hash] 
             : string.Empty;
    }

    private int HashFunction(string key)
    {
        int hash = 0;
        foreach (char c in key)
        {
            hash += c;
        }
        return hash % _hashTable.Length;
    }
}