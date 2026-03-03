namespace AlgorithmsDataStructures.DataStructures;

public class Queues
{
    public int MaxSize { get; set; } // Array queues needs to know the maximum size of the queue
    public string[] QueueArray { get; set; } // Array to hold the queue values
    public int Front { get; set; } // Pointer to the front of the queue
    public int Rear { get; set; } // Pointer to the rear of the queue
    public int NumberOfItems { get; set; } // Counter to keep track of the number of items in the queue

    public Queues(int size)
    {
        MaxSize = size;
        QueueArray = new string[MaxSize];
        Front = 0;
        Rear = -1;
        NumberOfItems = 0;
    }

    public void Enqueue(string value)
    {
        if (NumberOfItems == MaxSize)
        {
            Console.WriteLine("Queue is full. Cannot enqueue new value.");
            return;
        }
        Rear = (Rear + 1) % MaxSize; // Move rear pointer to the next position, wrap around if necessary
        QueueArray[Rear] = value; // Add the value to the rear of the queue
        NumberOfItems++; // Increment the number of items in the queue
    }

    public string Dequeue()
    {
        if (NumberOfItems == 0)
        {
            Console.WriteLine("Queue is empty. Cannot dequeue value.");
            return null!;
        }
        string value = QueueArray[Front]; // Get the value at the front of the queue
        QueueArray[Front] = default!; // Clear the value at the front of the queue
        Front = (Front + 1) % MaxSize; // Move front pointer to the next position, wrap around if necessary
        if (Front == MaxSize) Front = 0; // Wrap around if front reaches the end of the array
        NumberOfItems--; // Decrement the number of items in the queue
        return value;
    }

    public string Peek()
    {
        if (NumberOfItems == 0)
        {
            Console.WriteLine("Queue is empty. Cannot peek value.");
            return null!;
        }
        return QueueArray[Front]; // Return the value at the front of the queue without removing it
    }
}
