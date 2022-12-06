Console.Clear();
Console.WriteLine("Enter the minimum value of the array, the maximum value of the array and the length of the array: ");
int[] collection = GenerateArray(InputNum(),InputNum(),InputNum());
PrintArray(collection);
Console.WriteLine($"Amount of positive numbers equals: {SumPositivNumberInAnArray(collection)}");
int SumPositivNumberInAnArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length;  i++)
    {
        if(arr[i] % 2 == 0)
        {
            sum += 1;
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int InputNum()
{
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}