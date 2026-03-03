namespace AlgorithmsDataStructures.DataStructures.SearchAlgorithms;

public class BinarySearchArray
{
    /// <summary>
    /// Time Complexity: O(log n)
    /// Space Complexity: O(1)
    /// Note: The input array must be sorted for binary search to work correctly.
    /// Loop while the left pointer is less than or equal to the right pointer:
    /// Calculate the middle index and compare the middle element with the target:
    /// If they match, return true.
    /// If the middle element is less than the target, move the left pointer to mid + 1 (search in the right half).
    /// If the middle element is greater than the target, move the right pointer to mid - 1 (search in the left half).
    /// If the loop ends without finding the target, return false.
    /// </summary>
    /// <param name="array"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool Search(int[] array, int target)
    {
        return Search(array, target, false);
    }

    public bool Search(int[] array, int target, bool verbose)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + ((right - left) >> 1); // Avoids potential overflow
            // int mid = (left + right) / 2; // can cause overflow for large values of left and right

            if (verbose)
            {
                Display(left, mid, right, array);
            }

            if (array[mid] == target)
            {
                return true;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return false;
    }

    /// <summary>
    /// Displays the current `left`, `mid`, and `right` indices and their corresponding values.
    /// Useful for interactive/debugging to see the algorithm progress.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="mid"></param>
    /// <param name="right"></param>
    /// <param name="array"></param>
    public void Display(int left, int mid, int right, int[] array)
    {
        System.Console.WriteLine($"left={left} (val={array[left]}), mid={mid} (val={array[mid]}), right={right} (val={array[right]})");
    }

    
}