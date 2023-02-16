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

int [] array = GetArray(5, 0, 999) ;
Console.WriteLine(String.Join(", ", array));

int max = 0;
int min = 1000;

foreach (int element in array)
{
    if (element>max)
    {
        max = element;
    } 
}
foreach (int element in array)
{
    if (element < min)
    {
        min = element;
    }
}
Console.WriteLine(max-min);