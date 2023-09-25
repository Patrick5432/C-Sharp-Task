//Переменные
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 1;

//Массивы

int[][] globalArr = new int[b - a][];

for (int i = 0; a < b; i++)
{
    int[] arr = new int[9];
    for (int y = 0; y < arr.Length; y++)
    {
        arr[y] = a * count;
        Console.Write(arr[y] + " ");
        count++;
    }
    globalArr[i] = arr;
    Console.WriteLine();

    a++;
    count = 1;
}

Console.Write(globalArr[8][3]);