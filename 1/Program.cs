int pow(int num1, int num2)
{
    int result = 1;
    if (num2 == 0) return 1;
    for (int i = 0; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}

Console.Write("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(pow(num1, num2));
