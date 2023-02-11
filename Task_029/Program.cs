// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

int[] GetArray(int length, int LeftRange, int RightRange)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(LeftRange, RightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

var MyArray = GetArray(8, 0, 7);
PrintArray(MyArray);

