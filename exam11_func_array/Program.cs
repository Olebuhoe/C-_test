int[] arr = new int[10];
//Console.WriteLine(array);

void FillArray(int[] collection)
{
    int idx = 0;
    while (idx < collection.Length)
    {
        collection[idx] = new Random().Next(1, 10);
        idx++;
    }
}

void PrintArrElem(int[] array)
{
    int idx = 0;
    while (idx < array.Length)
    {
        Console.Write(array[idx] + " ");
        idx++;
    }
}

int IndexOf(int[] array, int find)
{
    int idx = 0;
    int pos = -100;
    while (idx < array.Length)
    {
        if (array[idx] == find)
        {
            pos = idx;
            break;
        }
        idx++;
    }
    return pos;
}

FillArray(arr);
PrintArrElem(arr);
Console.WriteLine();
Console.WriteLine(IndexOf(arr, 3));
