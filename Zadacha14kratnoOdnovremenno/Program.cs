// Напишите программу, которая принимает на вход число и проверякет, кртано ли оно одновременно 7 и 23

Console.WriteLine ("Введите 1 число");
int num =Convert.ToInt32 (Console.ReadLine());

if (num % 7 ==0 &&  num % 23 == 0)
{
    Console.WriteLine ($"{num} -> да");
}
else
{
    Console.WriteLine ($"{num} -> нет");
}