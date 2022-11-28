Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}
RandomArray(array);
PrintArray(array);