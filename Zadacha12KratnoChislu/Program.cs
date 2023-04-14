// Напишите программу, которая будет принимать на вход два числа и выводить,
// яыляется ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления

// 34, 5 ---- 4
// 16, 4----кратно

Console.WriteLine ("Введите 1 число");
int number1 =Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите 2 число");
int number2 =Convert.ToInt32 (Console.ReadLine());
int ostatok = number1%number2;
if(number1 / number2 == 0)
{
    Console.WriteLine ($"{number1}, {number2} -> кратно");
}
else
{
    Console.WriteLine ($"{number1}, {number2} -> {ostatok}");
}