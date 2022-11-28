Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;

    }
    return sum;
}

int sum = SumDigits(numA);

Console.Write($"Ваша сумма всех цифр - {sum} ");