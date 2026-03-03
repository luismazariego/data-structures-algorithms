namespace AlgorithmsDataStructures.DataStructures.SearchAlgorithms;

public class LinearSearchArray
{
    // Time Complexity: O(n)
    public bool Search(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return true;
            }
        }

        return false;
    }
}