Console.Clear();
Console.WriteLine("Enter the minimum value of the array, the maximum value of the array and the length of the array: ");
int[] collection = GenerateArray(InputNum(),InputNum(),InputNum());
int minDigit = MinDigitInArray(collection);
int maxDigit = MaxDigitInArray(collection);
PrintArray(collection);
Console.WriteLine($"The difference between the maximum and minimum element is: {maxDigit-minDigit}");



int MinDigitInArray(int[] arr)
{
    int index = 0;
    int min = arr[index];
    while(index < arr.Length)
    {
        if(min > arr[index])
        {
            min = arr[index];
        }
        index++;
    }
    return min;
}

int MaxDigitInArray(int[] arr)
{
    int index = 0;
    int max = arr[index];
    while(index < arr.Length)
    {
        if(max < arr[index])
        {
            max = arr[index];
        }
        index++;
    }
    return max;
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
