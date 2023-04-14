// Напишитк программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа
//786  ---- 76
//123----13
// 859 ----89

int number = new Random().Next(100, 1000);
int a = number / 100;
int b = number % 100;
int c = number % 10;

Console.WriteLine ($"number -> {number} ");
Console.WriteLine ($"a -> {a} ");
Console.WriteLine ($"b -> {b} ");
Console.WriteLine ($"c -> {c} ");

int result = a*10 + c;
 Console.WriteLine ($"{number}-> {result} ");
