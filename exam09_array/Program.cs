int MaxFunc(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
}

int[] arr = {1, 222, 51, 9, 18, 32, 43, 12, 87};

Console.WriteLine(MaxFunc(MaxFunc(arr[0], arr[1], arr[2]), 
                  MaxFunc(arr[3], arr[4], arr[5]), 
                  MaxFunc(arr[6], arr[7], arr[8])));
