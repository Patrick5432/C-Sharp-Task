// See https://aka.ms/new-console-template for more information

//Переменные
int a = 1;
int b = 10;
int count = 1;

//Массивы

int[][] globalArr = new int[b - a][];

for (int i = 0; a < b; i++)
{
    int[] arr = new int[9];
    for (int y = 0; y < arr.Length; y++)
    {
        arr[y] = a * count;
        globalArr[i] = arr;
        Console.Write(arr[y] + " ");
        count++;
    }
    Console.WriteLine();

    a++;
    count = 1;
}

Console.Write(globalArr[8][3]);