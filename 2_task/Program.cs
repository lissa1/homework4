//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int n = InputInt("введите число ");
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int FindSumNumber(int n)
{
    int sum = 0;
    while(n != 0) 
    { 
        sum += n % 10; 
        n /= 10; 
    } 
    return sum;
}
int sum = FindSumNumber(n);
Console.WriteLine($"суммa цифр в числе {n} равна {sum}");