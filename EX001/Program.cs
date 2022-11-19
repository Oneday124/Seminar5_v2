// Создайте массив, заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве
void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int NumberOfNumbers(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            result++;
    return result;

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
Console.WriteLine($"Количество четных элементов в массиве = {NumberOfNumbers(array)}");