string[] CreateArray (int size)
{
    string[] array = new string[size];
    System.Console.WriteLine("Enter array: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] FilterArray (string[] array)
{
    int size = 0;
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            size++;
        }
    }   

    string[] arrayResult = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            arrayResult[index] = array[i];
            index++;
        }
    }

    return arrayResult;
}

void PrintArray (string[] array)
{
    System.Console.WriteLine("[{0}]", string.Join(", ", array));
}

System.Console.WriteLine("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);

string[] resultArray = FilterArray(array);
PrintArray(resultArray);