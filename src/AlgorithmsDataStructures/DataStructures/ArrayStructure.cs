namespace AlgorithmsDataStructures.DataStructures;

public class ArrayStructure
{
    private readonly int[] _array;
    private int _length;

    public int[] Array => _array;

    public ArrayStructure(int capacity)
    {
        _array = new int[capacity];
        _length = 0;
        InitializaData();
    }

    public void DisplayArray()
    {
        Console.WriteLine($"[{string.Join(", ", _array)}]");
    }

    private void InitializaData()
    {
        for (int i = 0; i < 3; i++)
        {
            _array[_length] = i + 1;
            _length++;
        }
    }

    public void InsertAtEnd(int value)
    {
        if (_length < _array.Length)
        {
            _array[_length] = value;
            _length++;
        }
        else
        {
            Console.WriteLine("Array is full. Cannot insert new value.");
        }
    }

    public void InsertAtStart(int value)
    {
        if (_length < _array.Length)
        {
            for (int i = _length - 1; i >= 0; i--)
            {
                _array[i + 1] = _array[i];
            }
            _array[0] = value;
            _length++;
        }
        else
        {
            Console.WriteLine("Array is full. Cannot insert new value.");
        }
    }

    public void InsertAtPosition(int value, int position)
    {
        if (position < 0 || position > _length)
        {
            Console.WriteLine("Invalid position. Cannot insert new value.");
            return;
        }

        if (_length < _array.Length)
        {
            for (int i = _length - 1; i >= position; i--)
            {
                _array[i + 1] = _array[i];
            }
            _array[position] = value;
            _length++;
        }
        else
        {
            Console.WriteLine("Array is full. Cannot insert new value.");
        }
    }

    public void DeleteAtEnd()
    {
        if (_length > 0)
        {
            _length--;
            _array[_length] = 0; // Optional: Clear the last element
        }
        else
        {
            Console.WriteLine("Array is empty. Cannot delete value.");
        }
    }

    public void DeleteAtStart()
    {
        if (_length > 0)
        {
            for (int i = 1; i < _length; i++)
            {
                _array[i - 1] = _array[i];
            }
            _length--;
            _array[_length] = 0; // Optional: Clear the last element
        }
        else
        {
            Console.WriteLine("Array is empty. Cannot delete value.");
        }
    }

    /// <summary>
    /// Deletes the value at the specified position in the array. If the position is invalid, it displays an error message.
    /// </summary>
    /// <param name="position">The position of the value to delete. (zero based index)</param>
    public void DeleteAtPosition(int position)
    {
        if (position < 0 || position >= _length)
        {
            Console.WriteLine("Invalid position. Cannot delete value.");
            return;
        }                   

        for (int i = position + 1; i < _length; i++)
        {
            _array[i - 1] = _array[i];
        }
        _length--;
        _array[_length] = 0; // Optional: Clear the last element
    }
}