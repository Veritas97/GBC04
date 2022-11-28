Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num1, int num2)
{
    int sum = 1;
    for (int i = 1; i <= num2; i++)
    {
        sum = sum * num1;

    }
    return sum;
}

int sum = SumDigits(numberA, numberB);

Console.Write($"Натуральное число в кубе - {sum} ");