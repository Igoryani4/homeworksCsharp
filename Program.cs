// Home task 2 Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.WriteLine("Введите первое чило:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Наибольшее из введенных чисел является {number1}" );
    Console.WriteLine($"Наименьшее из введенных чисел является {number2}" );
}
else
{
    Console.WriteLine($"Наибольшее из введенных чисел является {number2}" );
    Console.WriteLine($"Наименьшее из введенных чисел является {number1}" );
}


//