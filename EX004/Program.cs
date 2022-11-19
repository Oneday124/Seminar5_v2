// Задан массив. Напишите функцию, коорая ищет заданное число в массиве и показывает нужный индекс. При отсутствии возвращать -1

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}

int IndexSearch(int[] array, int element)
{
    int index = -1;
    for(int i = 0; i < array.Length; i++)
        if(array[i] == element)
        {
            index = i;
            break;
        }
    return index;
    
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
System.Console.WriteLine("Введите элемент для поиска индекса: ");
int element = int.Parse(Console.ReadLine() !);

Console.Write($"{IndexSearch(array, element)}");
