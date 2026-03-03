namespace AlgorithmsDataStructures.DataStructures;

public class Stacks
{
    public int MaxSize { get; set; } // Array stacks needs to know the maximum size of the stack
    public string[] StackArray { get; set; } // Array to hold the stack values
    public int Top { get; set; } // Pointer to the top of the stack

    public Stacks(int size)
    {
        MaxSize = size;
        StackArray = new string[MaxSize];
        Top = -1; // Initialize top to -1 to indicate an empty stack
    }

    public void Push(string value)
    {
        if (Top == MaxSize - 1)
        {
            Console.WriteLine("Stack is full. Cannot push new value.");
            return;
        }
        Top++;
        StackArray[Top] = value; // Add the value to the top of the stack
    }

    public string Pop()
    {
        if (Top == -1)
        {
            Console.WriteLine("Stack is empty. Cannot pop value.");
            return null!;
        }       
        string value = StackArray[Top]; // Get the value at the top of the stack
        StackArray[Top] = default!; // Clear the value at the top of the stack
        Top--; // Move the top pointer down
        return value;
    }

    public string Peek()
    {
        if (Top == -1)
        {
            Console.WriteLine("Stack is empty. Cannot peek value.");
            return null!;
        }
        return StackArray[Top]; // Return the value at the top of the stack without removing it
    }

    public bool IsEmpty()
    {
        return Top == -1; // Stack is empty if top is -1
    }

    public bool IsFull()
    {
        return Top == MaxSize - 1; // Stack is full if top is at the last index
    }

    public void DisplayStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return;
        }
        Console.WriteLine("Stack contents:");
        for (int i = Top; i >= 0; i--)
        {
            Console.WriteLine(StackArray[i]);
        }
    }

}