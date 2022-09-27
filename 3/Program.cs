using System;
void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr.Length - 1 == i) Console.WriteLine($"{arr[i]}.");

        else Console.Write($"{arr[i]}, ");


    }
}

int[] createArr()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

printArr(createArr());