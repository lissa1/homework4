//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
int num1 = InputInt("введите число A: ");
int num2 = InputInt("введите число B: ");
int result = 1;
if (num2 < 0)
{
    num2 *= -1;
}
for (int i = 0; i < num2; i++)
{
    result *= num1;
}
Console.WriteLine(result);
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}