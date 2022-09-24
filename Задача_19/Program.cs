// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
 Console.WriteLine("Введите пятизначное число: ");
 int N = Convert.ToInt32(Console.ReadLine());


 if (N >= 10000 && N < 100000)
 {
     int one = N.ToString()[0] - '0';
     int two = N.ToString()[1] - '0';
     int three = N.ToString()[2] - '0';
     int four = N.ToString()[3] - '0';
     int five = N.ToString()[4] - '0';
     if (one == five && two == four)
     {
         Console.WriteLine($"{N} число является палиндромом");
     }
     else
     {
         Console.WriteLine($"{N} число не является палиндромом");
     }
 }
 else
 {
     Console.WriteLine("Введено некорректное число");
 }