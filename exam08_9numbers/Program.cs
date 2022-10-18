int MaxFunc(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
}

int a1 = 15;
int b1 = 9;
int c1 = 4;
int a2 = 11;
int b2 = 7;
int c2 = 14;
int a3 = 2;
int b3 = 8;
int c3 = 1;

//int max1 = MaxFunc(a1, b1, c1);
//int max2 = MaxFunc(a2, b2, c2);
//int max3 = MaxFunc(a3, b3, c3);

Console.WriteLine(MaxFunc(MaxFunc(a1, b1, c1), MaxFunc(a2, b2, c2), MaxFunc(a3, b3, c3)));
