// Usage example:
var sampleData = new[] { 12, 11, 13, 5, 6, 7 };
HeapSort.PerformSort(sampleData);
HeapSort.DisplayElements(sampleData);

public static class HeapSort
{
    public static void PerformSort(int[] dataSequence)
    {
        var totalElements = dataSequence.Length;

        // Build initial heap structure
        for (var parentIndex = totalElements / 2 - 1; parentIndex >= 0; parentIndex--)
            Heapify(dataSequence, totalElements, parentIndex);

        // Extract elements one by one
        for (var remainingElements = totalElements - 1; remainingElements > 0; remainingElements--)
        {
            // Move current root to end
            Swap(ref dataSequence[0], ref dataSequence[remainingElements]);
            
            // Heapify the reduced heap
            Heapify(dataSequence, remainingElements, 0);
        }
    }

    private static void Heapify(int[] dataSequence, int boundary, int rootPosition)
    {
        var dominantIndex = rootPosition;
        var leftChildPos = 2 * rootPosition + 1;
        var rightChildPos = 2 * rootPosition + 2;

        // Find largest among root and children
        if (leftChildPos < boundary && dataSequence[leftChildPos] > dataSequence[dominantIndex])
            dominantIndex = leftChildPos;

        if (rightChildPos < boundary && dataSequence[rightChildPos] > dataSequence[dominantIndex])
            dominantIndex = rightChildPos;

        // If largest is not root
        if (dominantIndex != rootPosition)
        {
            Swap(ref dataSequence[rootPosition], ref dataSequence[dominantIndex]);
            Heapify(dataSequence, boundary, dominantIndex);
        }
    }

    private static void Swap(ref int a, ref int b) => (a, b) = (b, a);

    public static void DisplayElements(int[] elements)
    {
        foreach (var element in elements)
            Console.Write($"{element} ");
        
        Console.WriteLine();
    }
}