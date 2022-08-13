//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Clear();
// Console.WriteLine("Введите трехзначное число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (Math.Abs(number) > 99 && Math.Abs(number) < 1000)
//   Console.WriteLine($" {(Math.Abs(number)-Math.Abs(number)%10)%Math.Abs(number)%100/10}");
// else
// {
//    Console.WriteLine("Вводите трехзначное число!");
// }

//Задача 13:Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// Console.Clear();
// Console.WriteLine("Введите трехзначное число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (Math.Abs(number) > 99)
// {
// while (Math.Abs(number)>999)
// {
//     number=number/10;
//  }
//     Console.WriteLine($" {Math.Abs(number) % 10}");
// }
// else
//   {
//        Console.WriteLine("Третьего числа нет!");
//    }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели:  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Введите цифру, от 1 до 7 !");


    while (number < 1 || number > 7)
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        if (number1 > 0 && number1 < 6)
        {
            Console.WriteLine(" Будний день:(");
        return;
        }
        if (number1 == 6 || number1 == 7)
        {
            Console.WriteLine(" УРА!!! ВЫХОДНОЙ:) ");
        return;
        }
         if   (number < 1 || number > 7)
         {
             Console.WriteLine("Введите цифру, от 1 до 7 !");
         }
    }
}
    if (number > 0 && number < 6)
    {
        Console.WriteLine(" Будний день:(");
    }
    if (number == 6 || number == 7)
    {
        Console.WriteLine(" УРА!!! ВЫХОДНОЙ:) ");
    }

