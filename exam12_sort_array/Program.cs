int[] arr = {7, 8, 5, 1, 4, 4, 2, 11};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos])
            {
                minPos = j;
            }
        }

        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPos])
            {
                maxPos = j;
            }
        }

        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}

SelectionSort(arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
SelectionSortMax(arr);
PrintArray(arr);
