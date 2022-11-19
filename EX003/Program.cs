// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

int DifferenseMaxMin (int[] array)
{
    int min = array[0];
    int max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        if(array[i] > max)
            max = array[i];
    }
    return max - min;          
}

void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
}

System.Console.WriteLine("Введите длинну массива: ");
int lenght = int.Parse(Console.ReadLine() !);
int[]array = new int[lenght];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Разница между max и min элементами массива = {DifferenseMaxMin(array)}");