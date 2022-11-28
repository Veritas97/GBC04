Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum = sum * i;

    }
    return sum;
}

int sumDigits = SumDigits(numberN);

Console.Write($"Ваша сумма всех цифр - {sum} ");