// See https://aka.ms/new-console-template for more information
int a = 4;
int b = 8;

int[] arr = new int[9];
int j = 1;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = a * j;
    Console.Write(arr[i] + " ");
    j++;
}