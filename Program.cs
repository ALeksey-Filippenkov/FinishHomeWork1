Console.WriteLine("Please enter the length of the array");
Console.WriteLine("The length of the array can only be a positive integer");
int size = Number();
Console.WriteLine();
string[] array = CreatArray(size);
int sizeNewArray = SearchSizeArray(array);
string[] newArray = CreatNewArray(sizeNewArray, array);
Console.WriteLine();
ShowNewArray(newArray);

int Number()
{
    System.Console.Write("Enter size: ");
    string bollSize = Console.ReadLine();
    int size;
    if (int.TryParse(bollSize, out size) && size > 0)
        return size;
    else
    {
        Console.Clear();
        Console.WriteLine("Please enter positive integers");
        return Number();
    }
}

string[] CreatArray(int size)
{
    string[] array = new string[size];
    Console.WriteLine($"Please enter {size} any words");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i + 1} word: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int SearchSizeArray(string[] array)
{
    int sizeNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            sizeNewArray++;
    }
    return sizeNewArray;
}

string[] CreatNewArray(int sizeNewArray, string[] array)
{
    string[] newArray = new string[sizeNewArray];
    for (int i = 0, j = 0; i < sizeNewArray; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void ShowNewArray(string[] newArray)
{
    Console.WriteLine("The new array consists of: ");
    for (int i = 0; i < newArray.Length; i++)
        Console.Write($"{newArray[i]} ");
}