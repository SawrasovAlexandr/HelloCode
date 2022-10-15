// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = { 11, 23, 45, 12, 545, 233, 63, 3, 22 };
// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8]));
// Console.WriteLine(max);

int[] array = { 12, 34, 565, 7, 87, 9894, 4335, 34, 76, 87 };
int n = array.Length;
int find = 87;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}