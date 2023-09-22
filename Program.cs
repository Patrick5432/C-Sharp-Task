// See https://aka.ms/new-console-template for more information
int a = 1;
int b = 10;

int[] arr = new int[9];
int j = 1;

while (a <= b)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a * j;
        Console.Write(arr[i] + " ");
        j++;
    }
    
    a++;
    j = 1;
    Console.WriteLine();
}