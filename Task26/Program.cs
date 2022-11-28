Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

if (numberN < 0) numberN = -numberN;
{
    int sumDigits = SumNumber(numberN);
    Console.WriteLine(sumDigits);
}