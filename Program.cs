//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//  2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdValue = Convert.ToInt32(Console.ReadLine());

if (firstValue > secondValue)
{
    if (firstValue > thirdValue)
    {
        Console.WriteLine ($"Максимальное число: {firstValue}");
    }
    else
    {
        Console.WriteLine ($"Максимальное число: {thirdValue}");
    }
}

else if (secondValue > thirdValue)
{
    Console.WriteLine($"Максимальное число:  {secondValue}");
}
else
{
    Console.WriteLine($"Максимальное число: {thirdValue}");
}