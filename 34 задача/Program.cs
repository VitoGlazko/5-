//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

int [] GetArray(int z, int min, int max)
{
    int[] result = new int[z];
    for (int i = 0; i<z; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

int [] array = GetArray(10, 100, 999) ;
Console.WriteLine(String.Join(", ", array));

int sum = 0;
foreach (int element in array)
{
    if (element % 2==0)
    {
        sum++;
    }
    else
    {
        sum= sum+0;
    }
}

Console.WriteLine($"Сумма чётных чисел в массиве равна {sum}");