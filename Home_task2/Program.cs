
//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

string number = Console.ReadLine();


Console.WriteLine(number[2]);


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string number2 = Console.ReadLine();

int length = number2.Length;

if(length < 3 ){
    Console.WriteLine("третьей цыфры нет");
}
else 
{
    Console.WriteLine(number2[2]);
}

//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

int number3 = int.Parse (Console.ReadLine());

if (number3 == 6 ){
    System.Console.WriteLine("Да");
}
if (number3 == 7 ){
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}