namespace AlgorithmsDataStructures.ADT;
public class Pokemon
{
    public string Name { get; set; }
    public int Level { get; set; }

    public Pokemon(string name, int level)
    {
        Name = name;
        Level = level;
    }
}