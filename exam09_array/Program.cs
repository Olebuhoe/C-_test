int[] arr = {1, 222, 51, 9, 18, 32, 43, 12, 87};
int idx = 0;
int find = 222;
//int n = arr.Length;

while (idx < arr.Length)
{
    if (arr[idx] == find)
    {
        Console.WriteLine(idx);
    }
    idx++;
}