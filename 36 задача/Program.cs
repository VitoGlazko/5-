//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int [] array = GetArray(5, -1000, 999) ;
Console.WriteLine(String.Join(", ", array));


int sum=0;
for(int i =1; i < array.Length; i++)
    if (i % 2!=0)
    {
        sum = sum+array[i];
    }
    Console.WriteLine(sum);
