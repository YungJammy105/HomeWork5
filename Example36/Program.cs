Console.Clear();
Console.WriteLine("Enter the minimum value of the array, the maximum value of the array and the length of the array: ");
int[] collection = GenerateArray(InputNum(),InputNum(),InputNum());
PrintArray(collection);
Console.WriteLine($"Sum of negative index in array equals: {SumNegatinIndexInAnArray(collection)}");


void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int SumNegatinIndexInAnArray(int[] coll)
{
    int sum = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += coll[i];
        }
    }
    return sum;
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