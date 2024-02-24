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

System.Console.WriteLine("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);