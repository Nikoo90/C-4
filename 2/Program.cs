int sumNum(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum += num % 10;
        num /= 10;

    }

    return sum;
}


Console.WriteLine(sumNum(9012)); //12