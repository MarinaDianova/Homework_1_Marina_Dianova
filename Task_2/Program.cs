// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberA > numberB)
{
    Console.WriteLine($"{numberA} больше {numberB}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"{numberA} меньше {numberB}");
}
else if (numberA == numberB)
{
    Console.WriteLine($"{numberA} равно {numberB}");
}