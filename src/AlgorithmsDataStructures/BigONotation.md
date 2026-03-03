# O(1)

- Constant time: execution time does not depend on input size.
- Typical examples: accessing an array element by index, reading/writing a variable, simple arithmetic.
- Memory usage stays constant (aside from fixed-size auxiliary storage).
- Very predictable and fast — useful for performance-critical operations.
- Ignores constant factors and low-level costs; notation focuses on growth relative to input.
- Hash table lookup is O(1) on average (worst-case can differ).

# O(n)

- Linear time: runtime grows proportionally with input size.
- Typical examples: scanning an array, counting, single loops.
- Think "for loops"
- while(i < 10) => O(N), N = 10

```csharp
// O(n) linear search
int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == target) return i;
    return -1;
}
```

# O(log n)

- Logarithmic time: input size reduces multiplicatively each step.
- Typical examples: binary search, operations on balanced trees.

```csharp
// O(log n) binary search (array must be sorted)
int BinarySearch(int[] arr, int target)
{
    int left = 0, right = arr.Length - 1;
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (arr[mid] == target) return mid;
        if (arr[mid] < target) left = mid + 1; else right = mid - 1;
    }
    return -1;
}
```

# O(n log n)

- Linearithmic time: typical for efficient comparison-based sorts.
- Typical examples: merge sort, heapsort, quicksort (average).

```csharp
// O(n log n) merge sort (concise example)
int[] MergeSort(int[] a)
{
    if (a.Length <= 1) return a;
    int mid = a.Length / 2;
    var left = MergeSort(a[..mid]);
    var right = MergeSort(a[mid..]);
    var result = new int[a.Length];
    int i = 0, l = 0, r = 0;
    while (l < left.Length && r < right.Length) result[i++] = (left[l] <= right[r]) ? left[l++] : right[r++];
    while (l < left.Length) result[i++] = left[l++];
    while (r < right.Length) result[i++] = right[r++];
    return result;
}
```

# O(n^2)

- Quadratic time: runtime scales with the square of input size.
- Typical examples: simple sorts (bubble, selection) and nested loops.

```csharp
// O(n^2) example: printing all pairs
void PrintPairs(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        for (int j = 0; j < a.Length; j++)
            Console.WriteLine($"{a[i]}, {a[j]}");
}
```

# O(2^n)

- Exponential time: runtime doubles with each additional input element.
- Typical examples: naive recursive solutions for combinatorial problems.

```csharp
// O(2^n) example: naive Fibonacci
int Fib(int n)
{
    if (n <= 1) return n;
    return Fib(n - 1) + Fib(n - 2);
}
```

# O(n!)

- Factorial time: grows extremely fast; small n becomes intractable.
- Typical examples: generating all permutations of n items.

```csharp
// O(n!) example: generate permutations (string-based example)
string Swap(string s, int i, int j)
{
    var ch = s.ToCharArray();
    var tmp = ch[i]; ch[i] = ch[j]; ch[j] = tmp;
    return new string(ch);
}

void Permute(string s, int l, int r)
{
    if (l == r) Console.WriteLine(s);
    else
    {
        for (int i = l; i <= r; i++)
        {
            s = Swap(s, l, i);
            Permute(s, l + 1, r);
            s = Swap(s, l, i);
        }
    }
}
```

---

Would you like shorter examples, or additional complexities explained?
