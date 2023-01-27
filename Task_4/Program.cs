// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}

Console.WriteLine($"Самое большое число: {max}");



// if (numberA > numberB)
// {
//     max = numberA;
// }
// else
// {
//     max = numberB;
// }
// if (max < numberC)
// {
//     max = numberC;
// }
// else
// {
//     max = max;
// }

// Console.WriteLine($"Самое большое число: {max}");