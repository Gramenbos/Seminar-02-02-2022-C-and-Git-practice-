void FillArray(int[] array)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 100);
    }
}

string PrintArray(int[] array)
{
    string stringArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            stringArray += $"{array[i]}";
            break;
        }
        stringArray += ($"{array[i]}, ");
    }
    stringArray += "]";
    return stringArray;
}

int EvenCounter(int[] array)
{
    int evenCounter = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            evenCounter++;
        }
    }
    return evenCounter;
}

int[] GenerateNewArray(int[] array)
{
    int[] resultArray = new int[EvenCounter(array)];
    int j = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            resultArray[j] = item;
            j++;
        }
    }
    return resultArray;
}

int[] workArray = new int[10];
FillArray(workArray);
string stringWorkArray = PrintArray(workArray);
int[] resultArray = GenerateNewArray(workArray);
string stringResultArray = PrintArray(resultArray);
Console.WriteLine(stringWorkArray + " -> " + stringResultArray);