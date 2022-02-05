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

int[] workArray = new int[10];
FillArray(workArray);
string stringWorkArray = PrintArray(workArray);
Console.WriteLine(stringWorkArray);