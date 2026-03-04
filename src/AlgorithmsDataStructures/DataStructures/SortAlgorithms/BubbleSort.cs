namespace AlgorithmsDataStructures.DataStructures.SortAlgorithms;

/// <summary>
/// O(n^2) time complexity
/// </summary>
public class BubbleSort
{
    public void Sort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n ; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap array[j] and array[j + 1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}