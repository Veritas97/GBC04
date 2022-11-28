Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

RandomArray(array);
PrintArray(array);