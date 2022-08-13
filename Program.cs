//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трехзначное число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 && number < 1000)
//   Console.WriteLine($" {(number-number%10)%number%100/10}");
// else
// {
//    Console.WriteLine("Вводите трехзначное число!");
// }

//Задача 13:Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) > 99)
{
while (Math.Abs(number)>999)
{
    number=number/10;
 }
    Console.WriteLine($" {Math.Abs(number) % 10}");
}
else
  {
       Console.WriteLine("Третьего числа нет!");
   }
