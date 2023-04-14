// напишите програииу, которая принимает на вход два числа и проверяет, является ли число квадратом другогою
// 5б 25 -> да
// -4, 16 -> да
// 8, 9 -> нет

Console.WriteLine ("Введите 1 число");
int num1 =Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите 2 число");
int num2 =Convert.ToInt32 (Console.ReadLine());
if (num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine ($"{num1}, {num2} -> да");
}
else
{
    Console.WriteLine ($"{num1}, {num2} -> нет");
}

